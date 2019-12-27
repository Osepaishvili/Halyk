using Abp.AutoMapper;
using Osepaishvili_Halyk_Task.Authentication.External;

namespace Osepaishvili_Halyk_Task.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
