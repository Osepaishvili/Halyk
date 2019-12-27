using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Osepaishvili_Halyk_Task.Controllers
{
    public abstract class Osepaishvili_Halyk_TaskControllerBase: AbpController
    {
        protected Osepaishvili_Halyk_TaskControllerBase()
        {
            LocalizationSourceName = Osepaishvili_Halyk_TaskConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
