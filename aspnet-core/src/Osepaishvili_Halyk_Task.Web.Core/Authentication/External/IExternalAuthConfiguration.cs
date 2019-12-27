using System.Collections.Generic;

namespace Osepaishvili_Halyk_Task.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
