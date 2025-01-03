using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommonModule.Common
{
    public class SalesPosition : FullAuditedEntity<int>
    {
        [MaxLength(250)]
        [Required]
        public virtual required string Name { get; set; }
    }
}
