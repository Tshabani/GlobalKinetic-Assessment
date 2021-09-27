using Abp.Authorization;
using Assessment.GlobalKinetic.Authorization.Roles;
using Assessment.GlobalKinetic.Authorization.Users;

namespace Assessment.GlobalKinetic.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
