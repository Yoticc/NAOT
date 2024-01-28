using Korn.Analyzer.Utils.Sugar;
using Korn.Core.Tasks;

namespace Korn.Analyzer.Tasks;
public class HandleNativeFuncsILTask : ILActualTask
{
    public override void Execute(ModuleDefMD module)
    {
        foreach ((var meth, var attribute) in module.GetMethodsByAttributeAndFoundAttribute(AGlobals.NativeFuncAttribute, AGlobals.NativeFuncAttribute_1))
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

            var attbrs = meth.CustomAttributes;

            attbrs.Remove(attribute);
            attbrs.Add(Helper.GetUnmanagedCallersOnlyAttribute(module, entryPoint, AGlobals.CallConvToNativeCallConvDic[callConvType]));
        }
    }
}