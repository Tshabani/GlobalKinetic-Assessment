using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Assessment.GlobalKinetic.Authorization.Roles;
using Assessment.GlobalKinetic.Authorization.Users;
using Assessment.GlobalKinetic.MultiTenancy;
using Assessment.GlobalKinetic.Coins;

namespace Assessment.GlobalKinetic.EntityFrameworkCore
{
    public class GlobalKineticDbContext : AbpZeroDbContext<Tenant, Role, User, GlobalKineticDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Coin> Coins { get; set; }

        public GlobalKineticDbContext(DbContextOptions<GlobalKineticDbContext> options)
            : base(options)
        {
        }
    }
}
