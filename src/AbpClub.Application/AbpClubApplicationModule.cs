using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.CmsKit;
using Volo.Abp.BlobStoring;
using Volo.Abp.BlobStoring.FileSystem;
using System.IO;
using Volo.CmsKit.MediaDescriptors;
using Volo.Docs;
using Volo.Docs.Admin;

namespace AbpClub
{
    [DependsOn(
        typeof(AbpClubDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(AbpClubApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(AbpSettingManagementApplicationModule),
        typeof(CmsKitApplicationModule),
        typeof(AbpBlobStoringFileSystemModule),
        typeof(DocsApplicationModule),
        typeof(DocsAdminApplicationModule)
        )]
    public class AbpClubApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpClubApplicationModule>();
            });
            //文件存储配置
            Configure<AbpBlobStoringOptions>(options =>
            {
                options.Containers.Configure<MediaContainer>(container =>
                {
                    container.UseFileSystem(fileSystem =>
                    {
                        container.IsMultiTenant = false;
                        var upload_images_path =Path.Combine(
                            Directory.GetCurrentDirectory()
                            ,"wwwroot"
                            ,"Uploads/Images/");
                        
                        //必须设置否则会引发异常
                        fileSystem.BasePath = upload_images_path;
                    });
                });
            });
        }
    }
}
