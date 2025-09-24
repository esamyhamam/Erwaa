using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ErwaaSystem.EntityFrameworkCore;
using ErwaaSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ErwaaSystem.Web.Tests;

[DependsOn(
    typeof(ErwaaSystemWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class ErwaaSystemWebTestModule : AbpModule
{
    public ErwaaSystemWebTestModule(ErwaaSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(ErwaaSystemWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(ErwaaSystemWebMvcModule).Assembly);
    }
}