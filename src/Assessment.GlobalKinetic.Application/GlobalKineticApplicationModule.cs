using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Assessment.GlobalKinetic.Authorization;

namespace Assessment.GlobalKinetic
{
    [DependsOn(
        typeof(GlobalKineticCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GlobalKineticApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GlobalKineticAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GlobalKineticApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
