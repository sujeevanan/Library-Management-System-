using Books.Contracts.Responses;
using Books.Domain;
using Mapster;

namespace Books.Application.Mappings;

public class MappingConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<List<Book>, GetBooksResponse>.NewConfig().Map(dest => dest.BookDtos, src => src);
    }
}