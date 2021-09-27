using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Assessment.GlobalKinetic.Configuration;
using Assessment.GlobalKinetic.EntityFrameworkCore;
using Assessment.GlobalKinetic.Migrator.DependencyInjection;

namespace Assessment.GlobalKinetic.Migrator
{
    [DependsOn(typeof(GlobalKineticEntityFrameworkModule))]
    public class GlobalKineticMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GlobalKineticMigratorModule(GlobalKineticEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(GlobalKineticMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                GlobalKineticConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(GlobalKineticMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
