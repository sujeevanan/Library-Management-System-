namespace Books.Contracts.Requests.Books;

public record CreateBookRequest(string Title, string Description, string Author,string Category);
