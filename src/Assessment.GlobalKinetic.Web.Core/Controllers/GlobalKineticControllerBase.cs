using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Assessment.GlobalKinetic.Controllers
{
    public abstract class GlobalKineticControllerBase: AbpController
    {
        protected GlobalKineticControllerBase()
        {
            LocalizationSourceName = GlobalKineticConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
