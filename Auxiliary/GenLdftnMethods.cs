class GenLdftnMethods
{
    public static string Gen()
        => Join('\n',
            Range(0, 16)
            .Select(i =>
            (string[])[
                $"public static delegate* unmanaged<{
                    Concat(
                        Range(0, i)
                        .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        .Select(s => $"{s}, ")
                    )
                }void> ldftn<{
                    Join(", ",
                        Range(0, i)
                        .Select(i => i == 0 ? "T" : $"T{i + 1}")
                    )
                }>(Action<{
                    Join(", ",
                        Range(0, i)
                        .Select(i => i == 0 ? "T" : $"T{i + 1}")
                    )
                }> method) => throw new NotImplementedException(ExceptionMessage);",

                i > 0 ? (
                    $"public static delegate* unmanaged<{
                        Join(", ",
                            Range(0, i)
                            .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        )
                    }> ldftn<{
                        Join(", ",
                            Range(0, i)
                            .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        )
                    }>(Func<{
                        Join(", ",
                            Range(0, i)
                            .Select(i => i == 0 ? "T" : $"T{i + 1}")
                        )
                    }> method) => throw new NotImplementedException(ExceptionMessage);"
                ) : ""
            ])
            .SelectMany(z => z)
            .Where(z => !IsNullOrEmpty(z))
            .Select(z => z.Replace("<>", "").Replace("Action ", "Delegate "))
            .OrderBy(s => s.Length)
            );
}