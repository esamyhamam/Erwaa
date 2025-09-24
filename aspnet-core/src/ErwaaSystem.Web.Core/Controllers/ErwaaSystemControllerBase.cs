using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ErwaaSystem.Controllers
{
    public abstract class ErwaaSystemControllerBase : AbpController
    {
        protected ErwaaSystemControllerBase()
        {
            LocalizationSourceName = ErwaaSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
