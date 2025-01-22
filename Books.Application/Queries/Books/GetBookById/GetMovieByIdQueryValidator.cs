using Books.Domain;
using FluentValidation;

namespace Books.Application.Queries.Books.GetBookById;

public class GetMovieByIdQueryValidator: AbstractValidator<GetBookByIdQuery>
{
    public GetMovieByIdQueryValidator()
    {
       RuleFor(x=>x.Id).NotEmpty()
           .WithMessage($"{nameof(Book.Id)} cannot be empty");
    }
}