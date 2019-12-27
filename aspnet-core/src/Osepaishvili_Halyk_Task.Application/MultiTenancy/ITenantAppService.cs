using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Osepaishvili_Halyk_Task.MultiTenancy.Dto;

namespace Osepaishvili_Halyk_Task.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

