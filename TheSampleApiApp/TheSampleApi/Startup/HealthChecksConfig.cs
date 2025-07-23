using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using TheSampleApi.HealthChecks;
using HealthChecks.UI.Client;

namespace TheSampleApi.Startup;

public static class HealthChecksConfig
{
    public static void AddAllHealthChecks(this IServiceCollection services)
    {
        services.AddHealthChecks()
            .AddCheck<RandomHealthCheck>("Random", tags: ["random"])
            .AddCheck<HealthyHealthCheck>("Healthy", tags: ["healthy"])
            .AddCheck<DegradedHealthCheck>("Degraded", tags: ["degraded"])
            .AddCheck<UnhealtyHealthCheck>("Unhealthy", tags: ["unhealthy"]);
    }

    public static void MappAllHealthChecks(this WebApplication app)
    {
        app.MapHealthChecks("/health");
        app.MapHealthChecks("/health/healthy", new HealthCheckOptions
        {
            Predicate = x => x.Tags.Contains("healthy"),
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
        app.MapHealthChecks("/health/degraded", new HealthCheckOptions
        {
            Predicate = x => x.Tags.Contains("degraded"),
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
        app.MapHealthChecks("/health/unhealthy", new HealthCheckOptions
        {
            Predicate = x => x.Tags.Contains("unhealthy"),
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
        app.MapHealthChecks("/health/random", new HealthCheckOptions
        {
            Predicate = x => x.Tags.Contains("random"),
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });

        app.MapHealthChecks("/health/ui", new HealthCheckOptions
        {
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
    }

}
