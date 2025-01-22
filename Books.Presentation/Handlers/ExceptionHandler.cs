using Books.Contracts.Exceptions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Movies.Presentation.Handlers;

public class ExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception,
        CancellationToken cancellationToken)
    {
        var problemDetails = CreateProblemDetails(exception);
        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);
        return true;

    }

    private static ProblemDetails CreateProblemDetails(Exception exception)
    {
        ProblemDetails problemDetails = exception switch
        {
            NotFoundException => CreateProblemDetails(StatusCodes.Status404NotFound, "Not found", exception.Message),
            CustomValidationException => CreateProblemDetails(StatusCodes.Status400BadRequest, "validation error",
                "one or more errors occured"),
            _ => CreateProblemDetails(StatusCodes.Status500InternalServerError, "Internal Server Error",
                "An Unexpected error occurred")
        };
        if (exception is CustomValidationException customValidationException)
        {
            problemDetails.Extensions["errors"] = customValidationException.ValidationErrors;
        }

        return problemDetails;

    }


    private static ProblemDetails CreateProblemDetails(int status, string title, string detail)
    {
        return new ProblemDetails
        {
            Status = status,
            Title = title,
            Detail = detail

        };
    }
}