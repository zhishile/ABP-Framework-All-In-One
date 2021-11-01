using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Volo.Abp.GlobalFeatures;
using Volo.CmsKit;

namespace AbpClub.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpClubDbContextFactory : IDesignTimeDbContextFactory<AbpClubDbContext>
    {
        public AbpClubDbContext CreateDbContext(string[] args)
        {
            //启用Cms-Kit全局功能
            /*
            GlobalFeatureManager.Instance.Modules.CmsKit(cmsKit =>
            {
                cmsKit.EnableAll();
            });
            */
            FeatureConfigurer.Configure();
            
            AbpClubEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpClubDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpClubDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpClub.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
