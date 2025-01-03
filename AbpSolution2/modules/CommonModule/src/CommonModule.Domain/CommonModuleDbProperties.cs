namespace CommonModule;

public static class CommonModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "CommonModule";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CommonModule";
}
