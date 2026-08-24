using Forms.API.Exceptions;
using System.Net;
using System.Text.Json;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(
        RequestDelegate next,
        ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro não tratado.");

            await HandleExceptionAsync(context, ex);
        }
    }

    private static async Task HandleExceptionAsync(
        HttpContext context,
        Exception exception)
    {
        context.Response.ContentType = "application/json";

        var statusCode = exception switch
        {
            ArgumentException => 400,
            UnauthorizedAccessException => 401,
            ForbiddenException => 403,
            KeyNotFoundException => 404,
            _ => 500
        };

        context.Response.StatusCode = statusCode;

        var response = new
        {
            Success = false,
            Message = exception.Message,
            StatusCode = statusCode
        };

        await context.Response.WriteAsync(
            JsonSerializer.Serialize(response));
    }
}