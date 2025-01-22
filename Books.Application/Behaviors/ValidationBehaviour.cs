using Books.Contracts.Errors;
using Books.Contracts.Exceptions;
using FluentValidation;
using MediatR;

namespace Books.Application.Behaviors;

public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
   
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);
        var validationResults = await Task.WhenAll(_validators.Select(x => x.ValidateAsync(context, cancellationToken)));
        var failures = validationResults.Where(x => !x.IsValid)
            .SelectMany(x => x.Errors)
            .Select(x => new ValidationError
            {
                PropertyName = x.PropertyName,
                ErrorMessage = x.ErrorMessage
            }).ToList();
        if (failures.Any())
        {
            throw new CustomValidationException(failures);
        }
        var response = await next();
        return response;
    }
}