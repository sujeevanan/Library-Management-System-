using Books.Contracts.Exceptions;
using Books.Contracts.Responses;
using Books.Domain;
using Books.Infrastructure;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Books.Application.Queries.Books.GetBookById;

public class GetBookByIdQueryHandler: IRequestHandler<GetBookByIdQuery, GetBookByIdResponse>
{
    private readonly BooksDbContext _booksDbContext;

    public GetBookByIdQueryHandler(BooksDbContext booksDbContext)
    {
        _booksDbContext = booksDbContext;
    }

    public async Task<GetBookByIdResponse> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        var movie=await _booksDbContext.Books.FirstOrDefaultAsync(x=>x.Id == request.Id, cancellationToken);
        if (movie is null)
        {
            throw new NotFoundException($"{nameof(Book)} with id {nameof(Book.Id)}: {request.Id}"+$"was not found in the database");
        }
        return movie.Adapt<GetBookByIdResponse>();
    }
}