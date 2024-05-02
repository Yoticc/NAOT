class GenCalliMethods
{
    public static string Gen()
        => Join('\n',
            Range(0, 16)
            .Select(i => 
            i == 0
            ?(string[])[
                "TOut calli<TOut>(cpointer pointer) => ((delegate* unmanaged<void>)pointer)();",
                "void calli(cpointer pointer) => ((delegate* unmanaged<TOut>)pointer)();"
             ]
            :[
                $"TOut calli<TOut, {Join(", ", Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}>(cpointer pointer, {Join(", ", Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")} arg{o}"))}) => ((delegate* unmanaged<{Join(", ", Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}, TOut>)pointer)({Join(", ", Range(1, i).Select(o => $"arg{o}"))});",
                $"void calli<{Join(", ", Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}>(cpointer pointer, {Join(", ", Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")} arg{o}"))}) => ((delegate* unmanaged<{Join(", ", Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}, void>)pointer)({Join(", ", Range(1, i).Select(o => $"arg{o}"))});"
             ])
            .SelectMany(z => z)
            .Select(s => $"public static {s}")
            .OrderBy(s => s.Length)
            );
}