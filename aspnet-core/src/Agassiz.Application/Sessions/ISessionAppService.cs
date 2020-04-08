using System.Threading.Tasks;
using Abp.Application.Services;
using Agassiz.Sessions.Dto;

namespace Agassiz.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
