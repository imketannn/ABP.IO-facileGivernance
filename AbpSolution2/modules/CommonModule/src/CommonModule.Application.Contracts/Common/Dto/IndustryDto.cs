using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace CommonModule.Common.Dto
{
    public class IndustryDto : EntityDto
    {
        [MaxLength(250)]
        [Required]
        public virtual required string Name { get; set; }
    }
}
