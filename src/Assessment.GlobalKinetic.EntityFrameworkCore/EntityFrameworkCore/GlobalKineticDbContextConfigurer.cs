using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Assessment.GlobalKinetic.EntityFrameworkCore
{
    public static class GlobalKineticDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GlobalKineticDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GlobalKineticDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
