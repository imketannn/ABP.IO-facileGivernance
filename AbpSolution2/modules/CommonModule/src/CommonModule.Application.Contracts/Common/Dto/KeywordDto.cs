using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace CommonModule.Common.Dto
{
    public class KeywordDto : EntityDto<int>
    {
        [MaxLength(250)]
        [Required]
        public virtual required string Name { get; set; }
        public virtual TypeIdentity IdentyType { get; set; }
    }
}
