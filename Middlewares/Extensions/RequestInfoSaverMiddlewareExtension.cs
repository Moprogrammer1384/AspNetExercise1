namespace AspNetExercise1.Middlewares.Extensions;

public static class RequestInfoSaverMiddlewareExtension
{
    public static IApplicationBuilder UseRequestInfoSaver
        (this IApplicationBuilder app)
    {
        app.UseMiddleware<RequestInfoSaverMiddleware>();

        return app;
    }
}
