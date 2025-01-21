using MediatR;

namespace Books.Application.Commands.Books.UpdateBook;

public record UpdateBookCommand(int Id,string Title,string Author,string Description,string Category) : IRequest<Unit>;