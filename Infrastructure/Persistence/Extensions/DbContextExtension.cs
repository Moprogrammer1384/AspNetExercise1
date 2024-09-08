using Microsoft.EntityFrameworkCore;
using System;

namespace AspNetExercise1.Infrastructure.Persistence.Extensions;

public static class DbContextExtension
{
    public static IServiceCollection AddApplicationDbContext
        (this IServiceCollection services,
         IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("RequestInfoDb"));
        });
        services.AddScoped<DbContext, ApplicationDbContext>();

        return services;
    }
}
