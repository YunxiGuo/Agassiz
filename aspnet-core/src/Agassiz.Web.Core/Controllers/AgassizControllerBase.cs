using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Agassiz.Controllers
{
    public abstract class AgassizControllerBase: AbpController
    {
        protected AgassizControllerBase()
        {
            LocalizationSourceName = AgassizConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
