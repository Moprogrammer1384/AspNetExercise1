using AspNetExercise1.Middlewares.Contracts;

namespace AspNetExercise1.Services.Extensions;

public static class SqlSaveInfoServiceExtension
{
    public static IServiceCollection AddRequestInfoSaver
        (this IServiceCollection services)
    {
        services.AddScoped<ISaveInfoService, SqlSaveInfoService>();

        return services;
    }
}
