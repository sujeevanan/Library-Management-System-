namespace Books.Contracts.Requests.Books;

public record UpdateBookRequest(int Id,string Title,string Description,string Author,string Category);