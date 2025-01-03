using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommonModule.Common
{
    public class Industry : FullAuditedEntity<int>
    {
        [MaxLength(250)]
        public virtual required string Name { get; set; }
    }
}
