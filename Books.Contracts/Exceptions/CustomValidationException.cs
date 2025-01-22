using Books.Contracts.Errors;

namespace Books.Contracts.Exceptions;

public class CustomValidationException: Exception
{
    private readonly List<ValidationError> _validationErrors;

    public CustomValidationException(List<ValidationError> validationErrors)
    {
        _validationErrors = validationErrors;
    }
    public List<ValidationError> ValidationErrors { get; set; }
    
}