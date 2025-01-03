using CommonModule.Common.Dto;
using Volo.Abp.Application.Services;

namespace CommonModule.Common;

public interface IKeywordAppService :
ICrudAppService< //Defines CRUD methods
    KeywordDto, //Used to show books
    int, //Primary key of the book entity
    PagedCommonResultRequestDto, //Used for paging/sorting/filter
    KeywordDto> //Used to create/update a book
{

}

