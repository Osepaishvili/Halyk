using Abp.Authorization;
using Osepaishvili_Halyk_Task.Authorization.Roles;
using Osepaishvili_Halyk_Task.Authorization.Users;

namespace Osepaishvili_Halyk_Task.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
