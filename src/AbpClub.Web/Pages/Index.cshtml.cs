using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace AbpClub.Web.Pages
{
    public class IndexModel : AbpClubPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}