using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Agassiz.Configuration;
using Agassiz.Web;

namespace Agassiz.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AgassizDbContextFactory : IDesignTimeDbContextFactory<AgassizDbContext>
    {
        public AgassizDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AgassizDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AgassizDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AgassizConsts.ConnectionStringName));

            return new AgassizDbContext(builder.Options);
        }
    }
}
