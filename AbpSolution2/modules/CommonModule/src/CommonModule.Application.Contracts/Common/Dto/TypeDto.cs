using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace CommonModule.Common.Dto
{
    public class TypeDto : EntityDto<int>
    {
        [MaxLength(250)]
        [Required]
        public virtual required string Name { get; set; }
        public virtual bool IsActive { get; set; }

        [Required]
        public virtual int IdentityType { get; set; }
        public virtual long? UserId { get; set; }
    }
}
