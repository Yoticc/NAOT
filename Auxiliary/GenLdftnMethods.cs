class GenLdftnMethods
{
    public static string Gen()
        => string.Join('\n',
            Enumerable.Range(0, 16)
            .Select(i =>
            new string[] {
                $"public static delegate* unmanaged<{
                    string.Concat(
                        Enumerable.Range(0, i)
                        .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        .Select(s => $"{s}, ")
                    )
                }void> ldftn<{
                    string.Join(", ",
                        Enumerable.Range(0, i)
                        .Select(i => i == 0 ? "T" : $"T{i + 1}")
                    )
                }>(Action<{
                    string.Join(", ",
                        Enumerable.Range(0, i)
                        .Select(i => i == 0 ? "T" : $"T{i + 1}")
                    )
                }> meth) => throw new NotImplementedException(ExceptionMessage);",

                i > 0 ? (
                    $"public static delegate* unmanaged<{
                        string.Join(", ",
                            Enumerable.Range(0, i)
                            .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        )
                    }> ldftn<{
                        string.Join(", ",
                            Enumerable.Range(0, i)
                            .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        )
                    }>(Func<{
                        string.Join(", ",
                            Enumerable.Range(0, i)
                            .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        )
                    }> meth) => throw new NotImplementedException(ExceptionMessage);"
                ) : ""
            })
            .SelectMany(z => z)
            .Where(z => !string.IsNullOrEmpty(z))
            .Select(z => z.Replace("<>", ""))
            );
}