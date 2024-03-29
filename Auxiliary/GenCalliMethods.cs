class GenCalliMethods
{
    public static string Gen()
        => string.Join('\n',
            Enumerable.Range(0, 16)
            .Select(i => 
            i == 0
            ?(string[])[
                "TOut calli<TOut>(cpointer pointer) => ((delegate* unmanaged<void>)pointer)();",
                "void calli(cpointer pointer) => ((delegate* unmanaged<TOut>)pointer)();"
             ]
            :[
                $"TOut calli<TOut, {string.Join(", ", Enumerable.Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}>(cpointer pointer, {string.Join(", ", Enumerable.Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")} arg{o}"))}) => ((delegate* unmanaged<{string.Join(", ", Enumerable.Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}, TOut>)pointer)({string.Join(", ", Enumerable.Range(1, i).Select(o => $"arg{o}"))});",
                $"void calli<{string.Join(", ", Enumerable.Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}>(cpointer pointer, {string.Join(", ", Enumerable.Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")} arg{o}"))}) => ((delegate* unmanaged<{string.Join(", ", Enumerable.Range(1, i).Select(o => $"T{(o == 1 ? "" : $"{o}")}"))}, void>)pointer)({string.Join(", ", Enumerable.Range(1, i).Select(o => $"arg{o}"))});"
             ])
            .SelectMany(z => z)
            .Select(s => $"public static {s}")
            .OrderBy(s => s.Length)
            );
}