using Serilog;

namespace ChatGPT_Asp_Net8_Integration.Extensions;

public static class SeriLogExtensions
{
    public static WebApplicationBuilder AddSerilog(
        this WebApplicationBuilder builder,
        IConfiguration configuration,
        string appName)
    {
        Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

        builder.Logging.ClearProviders();
        builder.Host.UseSerilog(Log.Logger, true);

        return builder;
    }
}
