using MediatR;

namespace Books.Application.Commands.Books.DeleteBook;

public record DeleteBookCommand(int Id) : IRequest<Unit>;