namespace Korn.Analyzer.Tasks;
public class HandleEntryPointTaskIL() : ILMainTask(-10)
{
    public override void Execute(ModuleDefMD module)
    {
        if (!CoreEnv.Config.EntryPoint.UseCustomEntryPoint)
            return;

        var config = CoreEnv.Config.EntryPoint.EntryPointPath;
        var isBypassNonStaticMethods = CoreEnv.Config.BypassNonStaticNativeMethods;
        if (config.Use)
        {
            var method = module.GetMethod(config.Path);
            if (method is null)
            {
                KornLogger.WriteError($"HandleEntryPointTaskIL: Unable find method with path \'{config.Path}\'");
                return;
            }
                        
            HandleEntryPoint(module, method);
        }
        else
        {
            var methods =
            module
            .GetMethodsByAttribute(Env.EntryPointAttribute)
            .Where(method =>
            {
                if (method.HasReturnType)
                {
                    KornLogger.ShowCriticalMessage($"EntryPoint {method.FullName} skipped because it's has return type");
                    return false;
                }

                if (!method.IsStatic && !isBypassNonStaticMethods)
                {
                    KornLogger.ShowCriticalMessage($"EntryPoint {method.FullName} skipped because it's not static");
                    return false;
                }

                if (!(method.Parameters.Count == 0 || (isBypassNonStaticMethods && method.Parameters.Count == 1 && method.Parameters[0].IsHiddenThisParameter)))
                {
                    KornLogger.ShowCriticalMessage($"EntryPoint {method.FullName} skipped because it's has parameters");
                    return false;
                }

                return true;
            }).ToList();

            if (methods.Count == 0)
            {
                KornLogger.ShowCriticalMessage("HandleEntryPointTaskIL: Error: Unable find EntryPoint method");
                return;
            }

            if (methods.Count > 1)
                KornLogger.ShowCriticalMessage($"HandleEntryPointTaskIL: Error: Found more than one EntryPoint methods. Handled first, other skipped (methods: {string.Join(", ", methods.Select(m => m.FullName))})");

            var method = methods[0];
            HandleEntryPoint(module, method);
        }        
    }

    void HandleEntryPoint(ModuleDefMD module, MethodDef method)
    {
        if (!method.IsStatic)
        {
            if (!CoreEnv.Config.BypassNonStaticNativeMethods)
            {
                KornLogger.WriteError("HandleEntryPointTaskIL->HandleEntryPoint: Cannot to use a non-static EntryPoint method. Make it static or set BypassNonStaticNativeMethods to \'true\'");
                return;
            }

            method.ModifyToStatic();
        }

        var customAttributes = method.CustomAttributes;

        var customAttributeIndex = customAttributes.ToList().FindIndex(a => a.AttributeType.IsSameByName(Env.EntryPointAttribute));
        if (customAttributeIndex != -1)
            customAttributes.RemoveAt(customAttributeIndex);
        customAttributes.Add(Helper.GetUnmanagedCallersOnlyAttribute(module, "Korn.Analyzer.EntryPoint", typeof(CallConvStdcall)));
    }
}

public unsafe class HandleEntryPointTaskASM() : ASMTask(-10)
{
    public override void Execute(string module)
    {
        if (!CoreEnv.Config.EntryPoint.UseCustomEntryPoint)
            return;

        var epName = "Korn.Analyzer.EntryPoint"u8;
        var internalDllMainName = "Korn.Internal.DllMain"u8;

        using var pe = new PEEditor(module);

        var epFunc = pe.GetExportFunctionAddress(epName);
        var epFuncFO = pe.Image->RvaToFileOffset(epFunc);
        var epFuncPtr = (byte*)pe.Image->ptr + epFuncFO;
        pe.RemoveExportFunction(epName);

        var internalDllMainFunc = pe.GetExportFunctionAddress(internalDllMainName);
        var internalDllMainFuncFO = pe.Image->RvaToFileOffset(pe.GetExportFunctionAddress(internalDllMainName));
        var internalDllMainFuncPtr = (byte*)pe.Image->ptr + internalDllMainFuncFO;
        pe.RemoveExportFunction(internalDllMainName);

        var originalEP = pe.EntryPoint;
        var originalEPFO = pe.Image->RvaToFileOffset(originalEP);
        var originalEPPtr = (byte*)pe.Image->ptr + originalEPFO;
        pe.EntryPoint = internalDllMainFunc;

        var internalDllMainFuncSize = pe.CalculateFunctionSize((nint)internalDllMainFuncPtr, [0x90, 0x90, 0x90, 0x90]);

        if (internalDllMainFuncSize == -1)
        {
            KornLogger.ShowCriticalMessage("HandleEntryPointTaskASM: Unable calculate size of Korn.Internal.DllMain function");
            return;
        }

        var foundFirstOffset = false;
        var foundSecondOffset = false;

        for (int i = 0; i < internalDllMainFuncSize; i++)
            internalDllMainFuncPtr[i] = 0x90;

        byte[] newBytes = [
            0x4C, 0x89, 0x44, 0x24, 0x18, 0x89, 0x54, 0x24, 0x10, 0x48, 0x89, 0x4C, 0x24, 0x08, 0x55, 0x57, 
            0x48, 0x81, 0xEC, 0xE8, 0x00, 0x00, 0x00, 0x48, 0x8D, 0x6C, 0x24, 0x20, 0x48, 0x8B, 0x85, 0xE0, 
            0x00, 0x00, 0x00, 0x48, 0x05, 0xAD, 0xDE, 0x00, 0x00, 0x4C, 0x8B, 0x85, 0xF0, 0x00, 0x00, 0x00, 
            0x8B, 0x95, 0xE8, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x8D, 0xE0, 0x00, 0x00, 0x00, 0xFF, 0xD0, 0x83, 
            0xBD, 0xE8, 0x00, 0x00, 0x00, 0x01, 0x75, 0x0F, 0x48, 0x8B, 0x85, 0xE0, 0x00, 0x00, 0x00, 0x48, 
            0x05, 0xEF, 0xBE, 0x00, 0x00, 0xFF, 0xD0, 0xB0, 0x01, 0x48, 0x8D, 0xA5, 0xC8, 0x00, 0x00, 0x00, 
            0x5F, 0x5D, 0xC3
        ];
        // bool main(nint module, int reason, void* reserved)
        // {
        //     (module + 0xDEAD)(module, reason, reserved);
        //     if (reason == 1)
        //         (module + 0xBEEF)();
        //     return true;
        // }

        for (int i = 0; i < newBytes.Length; i++)
            internalDllMainFuncPtr[i] = newBytes[i];

        for (int i = 0; i < internalDllMainFuncSize; i++)
        {
            var ptr = internalDllMainFuncPtr + i;
            var intPtr = (uint*)ptr;
            switch (*intPtr)
            {
                case 0xDEAD:
                    foundFirstOffset = true;
                    *intPtr = originalEP;
                    break;

                case 0xBEEF:
                    foundSecondOffset = true;
                    *intPtr = epFunc;
                    break;
            }
        }

        if (!foundFirstOffset)
        {
            KornLogger.ShowCriticalMessage("HandleEntryPointTaskASM: Unable found first offset in Korn.Internal.DllMain function");
            return;
        }
        if (!foundSecondOffset)
        {
            KornLogger.ShowCriticalMessage("HandleEntryPointTaskASM: Unable found second offset in Korn.Internal.DllMain function");
            return;
        }

        pe.Save(module);
    }
}