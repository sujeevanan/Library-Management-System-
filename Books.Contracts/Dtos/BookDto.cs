namespace Books.Contracts.Dtos;

public record BookDto(int Id, string Title, string Author,string Description, DateTime createDate,string Category);