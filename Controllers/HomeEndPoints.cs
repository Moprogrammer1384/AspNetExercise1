using System.Diagnostics;

namespace AspNetExercise1.Controllers;

public static class HomeEndPoints
{
    public static IEndpointRouteBuilder MapHomeEndPoints
       (this IEndpointRouteBuilder app)
    {
        app.MapGet("/", () => "Welcome to our website!!");

        return app;
    }
}
