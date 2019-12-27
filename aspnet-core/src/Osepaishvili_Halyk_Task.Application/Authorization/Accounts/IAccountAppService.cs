using System.Threading.Tasks;
using Abp.Application.Services;
using Osepaishvili_Halyk_Task.Authorization.Accounts.Dto;

namespace Osepaishvili_Halyk_Task.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
