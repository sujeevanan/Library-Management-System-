using Books.Contracts.Dtos;
using Books.Domain;
using Books.Infrastructure;
using MediatR;

namespace Books.Application.Commands.Books.CreateBook;

public class CreateBooksCommandHandler:IRequestHandler<CreateBookCommand, int>
{
    private readonly BooksDbContext _booksDbContext;

    public CreateBooksCommandHandler(BooksDbContext booksDbContext)
    {
        _booksDbContext = booksDbContext;
    }

    public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var book=new Book
        {
            Title = request.Title,
            Author = request.Author,
            Description = request.Description,
            Category = request.Category,
            CreateDate = DateTime.Now.ToUniversalTime()
        }
    }
}