using AbpClub.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpClub
{
    [DependsOn(
        typeof(AbpClubEntityFrameworkCoreTestModule)
        )]
    public class AbpClubDomainTestModule : AbpModule
    {

    }
}