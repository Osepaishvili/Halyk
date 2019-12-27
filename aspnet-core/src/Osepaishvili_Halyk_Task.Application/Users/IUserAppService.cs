using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Osepaishvili_Halyk_Task.Roles.Dto;
using Osepaishvili_Halyk_Task.Users.Dto;

namespace Osepaishvili_Halyk_Task.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
