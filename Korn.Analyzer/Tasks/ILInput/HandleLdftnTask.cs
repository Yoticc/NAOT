class HandleLdftnTask() : ILInputTask(-10)
{
    public override void Execute(ModuleDefMD module)
    {
        RedirectMethodCalls(module);
        StoreCompileGeneratedClasses();
        RemoveCompileGeneratedMembers();
        AddAtributesToUnNativeMethods(module);
    }

    List<FieldDef> compilerGeneratedFields;
    List<IMethodDefOrRef> usedUnnativedMethods;
    void RedirectMethodCalls(ModuleDefMD module)
    {
        compilerGeneratedFields = new();
        usedUnnativedMethods = new();
        Code[][] staticMethodCodeSequence = [
            [Code.Ldsfld],
            [Code.Dup],
            [Code.Brtrue, Code.Brtrue_S],
            [Code.Pop],
            [Code.Ldnull],
            [Code.Ldftn],
            [Code.Newobj],
            [Code.Dup],
            [Code.Stsfld]
        ];

        Code[] nonStaticMethoCodeSequence = [
            Code.Ldftn,
            Code.Newobj,
            Code.Call
        ];

        foreach (var type in module.GetTypes())
        {
            foreach (var method in type.Methods)
            {
                if (!method.HasBody)
                    continue;

                var body = method.Body;
                var instructions = body.Instructions;

                for (int i = 0; i < instructions.Count; i++)
                {
                    var instruction = instructions[i];
                    var opcode = instruction.OpCode;
                    var code = opcode.Code;

                    if (!CheckStaticMethods())
                        CheckNonStaticMethod();

                    bool CheckStaticMethods()
                    {
                        if (code != Code.Call)
                            return false;

                        var callInstruction = instruction;
                        var callMethod = (IMethod)instruction.Operand;

                        if (!callMethod.FullName.Contains("korn::ldftn"))
                            return false;

                        if (i < 9)
                            return false;

                        var broken = false;
                        var start = i - 9;
                        for (int o = start; o < i; o++)
                        {
                            if (!staticMethodCodeSequence[o - start].Contains(instructions[o].OpCode.Code))
                            {
                                broken = true;
                                break;
                            }
                        }

                        if (broken)
                            return false;

                        var ldsfldInstruction = instructions[start];
                        var ldsfldField = (FieldDef)ldsfldInstruction.Operand;
                        if (!compilerGeneratedFields.Contains(ldsfldField))
                            compilerGeneratedFields.Add(ldsfldField);

                        var ldftnInstruction = instructions[start + 5];
                        var ldftnMethod = (IMethodDefOrRef)ldftnInstruction.Operand;

                        if (!ldftnMethod.ContainsAttribute(Env.NativeMethodAttributes))
                            if (usedUnnativedMethods.Find(m => m.FullName == ldftnMethod.FullName) is null)
                                usedUnnativedMethods.Add(ldftnMethod);


                        instructions.RemoveAt(start, 5);
                        instructions.RemoveAt(start + 1, 4);

                        i -= 9;

                        return true;
                    }

                    void CheckNonStaticMethod()
                    {
                        if (code != Code.Ldarg_0)
                            return;

                        if (i >= instructions.Count - 4)
                            return;

                        var lastInst = instructions[i + 3];
                        var lastInstOpcode = lastInst.OpCode;
                        if (lastInstOpcode.Code != Code.Call)
                            return;

                        var callMeth = (IMethod)lastInst.Operand;
                        if (!callMeth.FullName.Contains("korn::ldftn"))
                            return;

                        var nextInst = instructions[i + 1];
                        var nextInstOpcode = nextInst.OpCode;
                        if (nextInstOpcode.Code != Code.Ldftn)
                            return;

                        for (var o = 0; o < nonStaticMethoCodeSequence.Length; o++)
                            if (instructions[i + o + 1].OpCode.Code != nonStaticMethoCodeSequence[o])
                                return;

                        var ldftnMeth = (MethodDef)nextInst.Operand;
                        if (!ldftnMeth.ContainsAttribute(Env.NativeMethodAttributes))
                            if (usedUnnativedMethods.Find(m => m.FullName == ldftnMeth.FullName) is null)
                                usedUnnativedMethods.Add(ldftnMeth);

                        instructions.RemoveAt(i + 3);
                        instructions.RemoveAt(i + 2);
                        instructions.RemoveAt(i);

                        i -= 3;
                    }
                }
            }
        }
    }

    List<TypeDef> compilerGeneratedClasses;
    void StoreCompileGeneratedClasses()
    {
        compilerGeneratedClasses = new();
        foreach (var field in compilerGeneratedFields)
            if (!compilerGeneratedClasses.Contains(field.DeclaringType))
                compilerGeneratedClasses.Add(field.DeclaringType);
    }

    void RemoveCompileGeneratedMembers()
    {
        foreach (var field in compilerGeneratedFields)
            field.DeclaringType.Fields.Remove(field);

        foreach (var type in compilerGeneratedClasses)
            if (type.IsEmpty())
                type.RemoveTypeFromModule();
    }

    void AddAtributesToUnNativeMethods(ModuleDefMD module)
    {
        foreach (var method in usedUnnativedMethods)
        {
            var attributes = method.CustomAttributes;

            var methodDefMD = method as MethodDef;
            if (methodDefMD is not null)
            {
                if (!methodDefMD.IsStatic)
                {
                    if (!CoreEnv.Config.BypassNonStaticNativeMethods)
                    {
                        Log.Error($"Detected native non static method {method.FullName}. It skipped because it's not static");
                        continue;
                    }   

                    methodDefMD.ModifyToStatic();
                }
            }

            var nativeAttribute = Helper.GetUnmanagedCallersOnlyAttribute(module, null, typeof(CallConvStdcall));
            attributes.Add(nativeAttribute);
        }
    }
}