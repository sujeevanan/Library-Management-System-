using Books.Domain;
using FluentValidation;

namespace Books.Application.Commands.Books.CreateBook;

public class CreateBookCommandValidator: AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(x=>x.Category)
            .NotEmpty().WithMessage($"{nameof(Book.Category)} cannot be empty")
            .MaximumLength(30)
            .WithMessage(x => $"{nameof(Book.Category)} cannot exceed 30 characters");
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage($"{nameof(Book.Title)} cannot be empty")
            .MaximumLength(100)
            .WithMessage(x => $"{nameof(Book.Title)} cannot exceed 100 characters");
        RuleFor(x => x.Author)
            .NotEmpty().WithMessage($"{nameof(Book.Author)} cannot be empty")
            .MaximumLength(100)
            .WithMessage(x => $"{nameof(Book.Author)} cannot exceed 100 characters");
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage($"{nameof(Book.Description)} cannot be empty")
            .MaximumLength(1000)
            .WithMessage(x => $"{nameof(Book.Description)} cannot exceed 1000 characters");
        
        
    }
}