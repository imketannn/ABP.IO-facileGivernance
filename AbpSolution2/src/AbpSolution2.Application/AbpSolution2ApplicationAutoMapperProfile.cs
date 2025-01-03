using AutoMapper;
using AbpSolution2.Books;

namespace AbpSolution2;

public class AbpSolution2ApplicationAutoMapperProfile : Profile
{
    public AbpSolution2ApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
