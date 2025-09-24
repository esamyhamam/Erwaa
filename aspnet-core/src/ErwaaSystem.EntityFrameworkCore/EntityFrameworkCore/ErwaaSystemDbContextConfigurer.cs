using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ErwaaSystem.EntityFrameworkCore;

public static class ErwaaSystemDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<ErwaaSystemDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<ErwaaSystemDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
