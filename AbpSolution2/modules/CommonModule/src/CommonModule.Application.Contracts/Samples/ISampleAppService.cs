using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace CommonModule.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
