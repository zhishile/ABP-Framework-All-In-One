using AbpClub.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpClub.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpClubController : AbpController
    {
        protected AbpClubController()
        {
            LocalizationResource = typeof(AbpClubResource);
        }
    }
}