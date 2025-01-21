using Books.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Books.Application.Commands.Books.DeleteBook;

public class DeleteBookCommandHandler: IRequestHandler<DeleteBookCommand, Unit>
{
    private readonly BooksDbContext _booksDbContext;

    public DeleteBookCommandHandler(BooksDbContext booksDbContext)
    {
        _booksDbContext = booksDbContext;
    }

    public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var bookToDelete=await _booksDbContext.Books.FirstOrDefaultAsync(x=>x.Id == request.Id, cancellationToken);
        if (bookToDelete is null)
        {
            throw new Exception();
        }
        _booksDbContext.Books.Remove(bookToDelete);
        await _booksDbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}