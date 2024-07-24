namespace Korn.Core.Utils;
public static partial class SugarExtensions
{
    public static IMethodDefOrRef? GetOperandMethod(this Instruction instruction) =>
        instruction.Operand is IMethodDefOrRef
        ? instruction.Operand as IMethodDefOrRef
        : instruction.Operand is MethodSpec
            ? (instruction.Operand as MethodSpec)!.Method
            : null
          ;

    public static int GetLdlocValue(this Instruction instruction) => instruction.OpCode.Code switch
    {
        Code.Ldloc_0 => 0,
        Code.Ldloc_1 => 1,
        Code.Ldloc_2 => 2,
        Code.Ldloc_3 => 3,
        Code.Ldloc_S => (int)instruction.Operand,
        Code.Ldloc => (int)instruction.Operand,
        _ => -1
    };

    public static int GetStlocValue(this Instruction instruction) => instruction.OpCode.Code switch
    {
        Code.Stloc_0 => 0,
        Code.Stloc_1 => 1,
        Code.Stloc_2 => 2,
        Code.Stloc_3 => 3,
        Code.Stloc_S => (int)instruction.Operand,
        Code.Stloc => (int)instruction.Operand,
        _ => -1
    };

    static readonly Code[] ldargaCodes = [Code.Ldarga, Code.Ldarga_S];
    public static bool IsLdarga(this Instruction instruction) => ldargaCodes.Contains(instruction.OpCode.Code);

    public static int GetLdargValue(this Instruction instruction, MethodDef method) => instruction.OpCode.Code switch
    {
        Code.Ldarg_0 => 0,
        Code.Ldarg_1 => 1,
        Code.Ldarg_2 => 2,
        Code.Ldarg_3 => 3,
        Code.Ldarg_S => method.Parameters.IndexOf(instruction.Operand as Parameter),
        Code.Ldarg => method.Parameters.IndexOf(instruction.Operand as Parameter),
        _ => -1
    };

    public static int GetLdargaValue(this Instruction instruction, MethodDef method) => method.Parameters.IndexOf(instruction.Operand as Parameter);

    static void SetParameterValue(this Instruction instruction, MethodDef method, int value) => instruction.Operand = method.Parameters.Count > value ? method.Parameters[value] : null;
    public static void SetLdargValue(this Instruction instruction, MethodDef method, int value) => instruction.SetParameterValue(method, value);
    public static void SetLdargaValue(this Instruction instruction, MethodDef method, int value) => instruction.SetParameterValue(method, value);

    static readonly Code[] stelemCodes = [Code.Stelem, Code.Stelem_I, Code.Stelem_I1, Code.Stelem_I2, Code.Stelem_I4, Code.Stelem_I8, Code.Stelem_R4, Code.Stelem_R8];
    public static bool IsStelem(this Code code) => stelemCodes.Contains(code);

    public static Instruction CreateLdarg(this MethodDef method, Parameter parameter) => parameter.Index switch
    {
        0 => OpCodes.Ldarg_0.ToInstruction(),
        1 => OpCodes.Ldarg_1.ToInstruction(),
        2 => OpCodes.Ldarg_2.ToInstruction(),
        3 => OpCodes.Ldarg_3.ToInstruction(),
        _ => Instruction.Create(OpCodes.Ldarg, parameter),
    };
}