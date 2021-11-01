using AbpClub.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpClub.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpClubEntityFrameworkCoreModule),
        typeof(AbpClubApplicationContractsModule)
        )]
    public class AbpClubDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
