using Volo.Abp.Application.Dtos;

namespace CommonModule.Common.Dto
{
    public class smtpSettingsDto : EntityDto<int>
    {
        public virtual string Server { get; set; }
        public virtual string User { get; set; }
        public virtual string Password { get; set; }
        public virtual int? IdentityType { get; set; }
    }
}
