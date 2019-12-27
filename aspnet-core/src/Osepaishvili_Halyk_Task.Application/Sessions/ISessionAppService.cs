using System.Threading.Tasks;
using Abp.Application.Services;
using Osepaishvili_Halyk_Task.Sessions.Dto;

namespace Osepaishvili_Halyk_Task.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
