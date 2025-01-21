using MediatR;

namespace Books.Application.Commands.Books.CreateBook;

public record CreateBookCommand(string Title, string Author, string Description,string Category) : IRequest<int>;