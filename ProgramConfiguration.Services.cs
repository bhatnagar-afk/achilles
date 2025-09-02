namespace achilles;

internal static partial class ProgramConfiguration
{
    internal static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddOpenApi("v1");
        services.AddEndpointsApiExplorer();
    }
}
