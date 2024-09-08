using AspNetExercise1.Application.Dtos;
using AspNetExercise1.Middlewares.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExercise1.Middlewares;

public class RequestInfoSaverMiddleware
{
    private readonly RequestDelegate _next;    

    public RequestInfoSaverMiddleware(
        RequestDelegate next)
    {
        this._next = next;
    }

    public async Task InvokeAsync(
        HttpContext context, 
        [FromServices]ISaveInfoService _saveInfoService)
    {
        var requestInfo = new RequestInfoDto(
            context.Request.Method, 
            context.Request.Headers["User-Agent"].ToString());
        

        await _saveInfoService.Save(requestInfo);

        await _next(context);
    }
}
