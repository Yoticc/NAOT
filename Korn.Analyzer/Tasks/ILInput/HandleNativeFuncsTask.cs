using Korn.Analyzer;
using Korn.Analyzer.Utils.Sugar;
using Korn.Core.Tasks;
using Korn.Core.Utils;

class HandleNativeFuncsTask() : ILInputTask(-10)
{
    public override void Execute(ModuleDefMD module)
    {
        foreach ((var method, var attribute) in module.GetMethodsByAttributeAndFoundAttribute(AGlobals.NativeFuncAttribute, AGlobals.NativeFuncAttribute_1))
        {
            string? entryPoint = null;
            var callConvType = CallConvType.cdelc;

            var type = attribute.AttributeType;
            if (type.NumberOfGenericParameters != 0)
            {
                var callConvSig = type.FullName.Split('<')[1].Split('>')[0];
                callConvType = AGlobals.SigToCallConvDic[callConvSig];
            }

            var attributeArguments = attribute.ConstructorArguments.ToList();
            if (attributeArguments.Count > 0)
            {
                entryPoint = (string)(UTF8String)attributeArguments[0].Value;
                entryPoint = string.IsNullOrEmpty(entryPoint) ? null : entryPoint;
            }

            var attributes = method.CustomAttributes;

            attributes.Remove(attribute);
            attributes.Add(Helper.GetUnmanagedCallersOnlyAttribute(module, entryPoint, AGlobals.CallConvToNativeCallConvDic[callConvType]));
        }
    }
}