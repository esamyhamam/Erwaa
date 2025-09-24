using Abp.Modules;
using Abp.Reflection.Extensions;
using ErwaaSystem.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ErwaaSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(ErwaaSystemWebCoreModule))]
    public class ErwaaSystemWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ErwaaSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ErwaaSystemWebHostModule).GetAssembly());
        }
    }
}
