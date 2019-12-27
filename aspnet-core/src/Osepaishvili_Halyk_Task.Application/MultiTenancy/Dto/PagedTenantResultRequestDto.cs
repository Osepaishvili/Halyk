using Abp.Application.Services.Dto;

namespace Osepaishvili_Halyk_Task.MultiTenancy.Dto
{
    public class PagedTenantResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}

