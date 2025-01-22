using Books.Domain;
using FluentValidation;

namespace Books.Application.Commands.Books.DeleteBook;

public class DeleteBookCommandValidator: AbstractValidator<DeleteBookCommand>
{
    public DeleteBookCommandValidator()
    {
        RuleFor(x=>x.Id).NotEmpty()
            .WithMessage($"{nameof(Book.Id)} cannot be empty");
    }
}