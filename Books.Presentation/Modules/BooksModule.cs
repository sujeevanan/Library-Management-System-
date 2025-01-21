using Books.Application.Commands.Books.CreateBook;
using Books.Application.Commands.Books.DeleteBook;
using Books.Application.Commands.Books.UpdateBook;
using Books.Application.Queries.Books.GetBookById;
using Books.Application.Queries.Books.GetBooks;
using Books.Contracts.Requests.Books;
using MediatR;

namespace Books.Presentation.Modules;

public static class BooksModule
{
    public static void AddBooksEndPoints(this IEndpointRouteBuilder app)
    {
        //get the books 
        app.MapGet("/api/books", async (IMediator mediator, CancellationToken ct) =>
        {
            var books = await mediator.Send(new GetBooksQuery(), ct);
            return Results.Ok(books);
        }).WithTags("Books");
        
        //get the book by the id 
        app.MapGet("/api/books/{id}", async (IMediator mediator, int id, CancellationToken ct) =>
        {
            var book = await mediator.Send(new GetBookByIdQuery(id));
            return Results.Ok(book);
        }).WithTags("Books");
        
        //create a book use post method
        app.MapPost("/api/books", async (IMediator mediator, CreateBookRequest createBookRequest,CancellationToken ct) =>
        {
            var command=new CreateBookCommand(createBookRequest.Title,createBookRequest.Description,createBookRequest.Author,createBookRequest.Category);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Books");
        
        //update book use put method 
        app.MapPut("/api/books/{id}",
            async (IMediator mediator, int id, UpdateBookRequest updateBookRequest, CancellationToken ct) =>
            {
                var command=new UpdateBookCommand(id,updateBookRequest.Title,updateBookRequest.Description,updateBookRequest.Author,updateBookRequest.Category);
                var result = await mediator.Send(command, ct);
                return Results.Ok(result);
            }).WithTags("Books");
        
        //delete book use delete method 
        app.MapDelete("/api/books/{id}", async (IMediator mediator, int id, CancellationToken ct) =>
        {
            var command = new DeleteBookCommand(id);
            var result = await mediator.Send(command, ct);
            return Results.Ok(result);
        }).WithTags("Books");
        
        
    }
    
}