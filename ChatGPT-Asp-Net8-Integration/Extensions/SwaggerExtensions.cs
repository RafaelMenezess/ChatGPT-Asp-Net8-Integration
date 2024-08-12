using Microsoft.OpenApi.Models;

namespace ChatGPT_Asp_Net8_Integration.Extensions;

public static class SwaggerExtensions
{
    public static void AddSwagger(
        this IServiceCollection services,
        IConfiguration configuration,
        string appName)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = appName,
                Version = "v1",
            });
            c.ResolveConflictingActions(apiDescription => apiDescription.First());
        });
    }

    public static void UseSwaggerDoc(
        this IApplicationBuilder app,
        string appName)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", appName);
            c.RoutePrefix = "swagger";
        });
    }
}
