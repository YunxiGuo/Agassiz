using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Agassiz.EntityFrameworkCore
{
    public static class AgassizDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AgassizDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AgassizDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
