namespace achilles;

internal static partial class ProgramConfiguration
{
    internal static void ConfigureMiddleware(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi(); 
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
    }
}
