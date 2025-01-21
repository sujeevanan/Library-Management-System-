using Books.Contracts.Dtos;

namespace Books.Contracts.Responses;

public record GetBookByIdResponse(BookDto BookDto);