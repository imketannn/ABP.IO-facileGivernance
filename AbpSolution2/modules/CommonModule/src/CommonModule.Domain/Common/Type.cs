using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommonModule.Common
{
    public class Type : FullAuditedEntity<int>
    {
        [MaxLength(250)]
        [Required]
        public virtual required string Name { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual TypeIdentity IdentyType { get; set; }
        public virtual long? UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User UserFk { get; set; }
    }   

}
