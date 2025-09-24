using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ErwaaSystem.Configuration;
using ErwaaSystem.EntityFrameworkCore;
using ErwaaSystem.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace ErwaaSystem.Migrator;

[DependsOn(typeof(ErwaaSystemEntityFrameworkModule))]
public class ErwaaSystemMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public ErwaaSystemMigratorModule(ErwaaSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(ErwaaSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            ErwaaSystemConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(ErwaaSystemMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
