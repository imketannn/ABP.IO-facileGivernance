using AutoMapper;
using CommonModule.Common;
using CommonModule.Common.Dto;

namespace CommonModule;

public class CommonModuleApplicationAutoMapperProfile : Profile
{
    public CommonModuleApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Keyword, KeywordDto>().ReverseMap();
        CreateMap<Industry, IndustryDto>().ReverseMap();
        CreateMap<Type, TypeDto>().ReverseMap();
        CreateMap<SalesPosition, SalesPositionDto>().ReverseMap();
    }
}
