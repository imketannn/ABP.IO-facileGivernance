using Volo.Abp.Application.Dtos;

namespace CommonModule.Common.Dto
{
    public class PagedCommonResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string? Keyword { get; set; }
        public int id { get; set; }
        public virtual int IdentityType { get; set; }
    }
}
