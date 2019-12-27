using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Osepaishvili_Halyk_Task.MultiTenancy;

namespace Osepaishvili_Halyk_Task.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
