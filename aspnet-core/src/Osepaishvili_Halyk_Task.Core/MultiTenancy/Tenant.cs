using Abp.MultiTenancy;
using Osepaishvili_Halyk_Task.Authorization.Users;

namespace Osepaishvili_Halyk_Task.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
