using Books.Contracts.Exceptions;
using Books.Domain;
using Books.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Books.Application.Commands.Books.UpdateBook;

public class UpdateBookCommandHandler: IRequestHandler<UpdateBookCommand, Unit>
{
    private readonly BooksDbContext _booksDbContext;

    public UpdateBookCommandHandler(BooksDbContext booksDbContext)
    {
        _booksDbContext = booksDbContext;
    }

    public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
    {
        var bookToUpdate=await _booksDbContext.Books.FirstOrDefaultAsync(x=>x.Id==request.Id, cancellationToken);
        if (bookToUpdate is null)
        {
            throw new NotFoundException($"{nameof(Book)} with id {nameof(Book.Id)}: {request.Id}"+$"was not found in the database");
        }
        bookToUpdate.Description = request.Description;
        bookToUpdate.Author = request.Author;
        bookToUpdate.Title = request.Title;
        bookToUpdate.Category=request.Category;
        _booksDbContext.Books.Update(bookToUpdate);
        await _booksDbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}