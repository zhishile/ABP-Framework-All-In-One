using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpClub.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpClubBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpClub";
    }
}
