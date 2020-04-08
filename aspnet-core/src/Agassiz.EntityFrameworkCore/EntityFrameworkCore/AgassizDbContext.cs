using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Agassiz.Authorization.Roles;
using Agassiz.Authorization.Users;
using Agassiz.MultiTenancy;

namespace Agassiz.EntityFrameworkCore
{
    public class AgassizDbContext : AbpZeroDbContext<Tenant, Role, User, AgassizDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AgassizDbContext(DbContextOptions<AgassizDbContext> options)
            : base(options)
        {
        }
    }
}
