using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Assessment.GlobalKinetic.EntityFrameworkCore;
using Assessment.GlobalKinetic.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Assessment.GlobalKinetic.Web.Tests
{
    [DependsOn(
        typeof(GlobalKineticWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GlobalKineticWebTestModule : AbpModule
    {
        public GlobalKineticWebTestModule(GlobalKineticEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GlobalKineticWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GlobalKineticWebMvcModule).Assembly);
        }
    }
}