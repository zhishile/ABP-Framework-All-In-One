using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpClub
{
    [Dependency(ReplaceServices = true)]
    public class AbpClubBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpClub";
    }
}
