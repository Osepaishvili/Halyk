using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Osepaishvili_Halyk_Task.Configuration.Dto;

namespace Osepaishvili_Halyk_Task.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Osepaishvili_Halyk_TaskAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
