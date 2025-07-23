using Scalar.AspNetCore;

namespace TheSampleApi.Startup
{
    public static class OpenApiConfig
    {
        public static void AppOpenApiServices(this IServiceCollection services)
        { 
            services.AddOpenApi();
        }

        public static void UseOpenApi(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference(options =>
                {
                    options.Title = "The Sample API";
                    options.Theme = ScalarTheme.Purple;
                    options.Layout = ScalarLayout.Modern;
                    options.HideClientButton = true;


                });
            }
        }
    }
}
