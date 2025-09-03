using achilles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

ProgramConfiguration.ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

ProgramConfiguration.ConfigureRoutes(app);
ProgramConfiguration.ConfigureMiddleware(app);

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}