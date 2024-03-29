using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korn.Core.Utils;
public static partial class SugarExtensions
{
    public static IList<Instruction> Add(this IList<Instruction> instructions, params Instruction[] entries)
    {
        foreach (var entry in entries)
            instructions.Add(entry);

        return instructions;
    }

    public static IList<Instruction> Insert(this IList<Instruction> instructions, int index, params Instruction[] entries)
    {
        for (var i = 0; i < entries.Length; i++)
            instructions.Insert(index + i, entries[i]);

        return instructions;
    }

    public static IList<Instruction> RemoveAt(this IList<Instruction> instructions, int index, int count = 1)
    {
        for (var i = 0; i < count; i++)
            instructions.RemoveAt(index);

        return instructions;
    }
}