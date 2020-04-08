using Abp.Authorization;
using Agassiz.Authorization.Roles;
using Agassiz.Authorization.Users;

namespace Agassiz.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
