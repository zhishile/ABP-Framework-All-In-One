using Volo.Abp.Modularity;

namespace AbpClub
{
    [DependsOn(
        typeof(AbpClubApplicationModule),
        typeof(AbpClubDomainTestModule)
        )]
    public class AbpClubApplicationTestModule : AbpModule
    {

    }
}