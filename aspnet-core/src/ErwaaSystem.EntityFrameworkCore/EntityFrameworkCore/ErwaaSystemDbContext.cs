using Abp.Zero.EntityFrameworkCore;
using ErwaaSystem.Authorization.Roles;
using ErwaaSystem.Authorization.Users;
using ErwaaSystem.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace ErwaaSystem.EntityFrameworkCore;

public class ErwaaSystemDbContext : AbpZeroDbContext<Tenant, Role, User, ErwaaSystemDbContext>
{
    /* Define a DbSet for each entity of the application */

    public ErwaaSystemDbContext(DbContextOptions<ErwaaSystemDbContext> options)
        : base(options)
    {
    }
}
