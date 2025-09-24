using Abp.Authorization;
using ErwaaSystem.Authorization.Roles;
using ErwaaSystem.Authorization.Users;

namespace ErwaaSystem.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
