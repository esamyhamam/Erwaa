using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ErwaaSystem.Authorization;

namespace ErwaaSystem;

[DependsOn(
    typeof(ErwaaSystemCoreModule),
    typeof(AbpAutoMapperModule))]
public class ErwaaSystemApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<ErwaaSystemAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(ErwaaSystemApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
