using Books.Contracts.Responses;
using MediatR;

namespace Books.Application.Queries.Books.GetBookById;

public record GetBookByIdQuery(int Id): IRequest<GetBookByIdResponse>;