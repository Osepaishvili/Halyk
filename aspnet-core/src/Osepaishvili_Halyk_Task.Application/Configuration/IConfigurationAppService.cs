using System.Threading.Tasks;
using Osepaishvili_Halyk_Task.Configuration.Dto;

namespace Osepaishvili_Halyk_Task.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
