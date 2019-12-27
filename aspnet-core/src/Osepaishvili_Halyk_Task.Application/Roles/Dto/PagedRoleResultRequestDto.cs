using Abp.Application.Services.Dto;

namespace Osepaishvili_Halyk_Task.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

