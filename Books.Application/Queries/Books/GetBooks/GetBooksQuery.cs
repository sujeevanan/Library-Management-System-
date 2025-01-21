using Books.Contracts.Responses;
using MediatR;

namespace Books.Application.Queries.Books.GetBooks;

public record GetBooksQuery():IRequest<GetBooksResponse>;