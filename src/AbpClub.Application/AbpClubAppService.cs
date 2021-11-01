using System;
using System.Collections.Generic;
using System.Text;
using AbpClub.Localization;
using Volo.Abp.Application.Services;

namespace AbpClub
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpClubAppService : ApplicationService
    {
        protected AbpClubAppService()
        {
            LocalizationResource = typeof(AbpClubResource);
        }
    }
}
