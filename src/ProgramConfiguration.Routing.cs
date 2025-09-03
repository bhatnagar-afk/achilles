namespace achilles;

internal partial class ProgramConfiguration
{
    internal static void ConfigureRoutes(WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");
    }
}