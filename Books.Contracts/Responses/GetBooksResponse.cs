using Books.Contracts.Dtos;

namespace Books.Contracts.Responses;

public record GetBooksResponse(List<BookDto> BookDtos);