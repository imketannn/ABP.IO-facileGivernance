using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommonModule.Common
{
    public class Keyword : FullAuditedEntity<int>
    {
        [MaxLength(250)]
        [Required]
        public virtual required string Name { get; set; }
        public virtual TypeIdentity IdentyType { get; set; }
    }
}
