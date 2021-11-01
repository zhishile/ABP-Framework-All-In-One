using AbpClub.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpClub.Web.Pages
{
    public abstract class AbpClubPageModel : AbpPageModel
    {
        protected AbpClubPageModel()
        {
            LocalizationResourceType = typeof(AbpClubResource);
        }
    }
}