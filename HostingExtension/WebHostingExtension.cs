using AspNetExercise1.Infrastructure.Persistence.Extensions;
using AspNetExercise1.Middlewares.Extensions;
using AspNetExercise1.Services.Extensions;

namespace AspNetExercise1.HostingExtension;

public static class WebHostingExtension
{
    public static WebApplication ConfigureServices
        (this WebApplicationBuilder builder)
    {
        builder.Services.AddRequestInfoSaver();
        builder.Services.AddApplicationDbContext(builder.Configuration);

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseRequestInfoSaver();
        app.MapGet("/", () => "Welcome to our website!!");


        return app;
    }
}
