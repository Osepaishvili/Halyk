using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Osepaishvili_Halyk_Task.Authorization.Users;
using Osepaishvili_Halyk_Task.Editions;

namespace Osepaishvili_Halyk_Task.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
