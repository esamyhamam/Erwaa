using ErwaaSystem.Configuration;
using ErwaaSystem.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ErwaaSystem.EntityFrameworkCore;

/* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
public class ErwaaSystemDbContextFactory : IDesignTimeDbContextFactory<ErwaaSystemDbContext>
{
    public ErwaaSystemDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ErwaaSystemDbContext>();

        /*
         You can provide an environmentName parameter to the AppConfigurations.Get method. 
         In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
         Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
         https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
         */
        var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

        ErwaaSystemDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ErwaaSystemConsts.ConnectionStringName));

        return new ErwaaSystemDbContext(builder.Options);
    }
}
