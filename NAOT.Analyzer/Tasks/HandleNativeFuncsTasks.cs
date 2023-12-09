using dnlib.DotNet;
using dnlib.DotNet.Emit;
using NAOT.Analyzer.Utils.Sugar;
using NAOT.Core.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Tasks;
public class HandleNativeFuncsTasks : ILActualTask
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