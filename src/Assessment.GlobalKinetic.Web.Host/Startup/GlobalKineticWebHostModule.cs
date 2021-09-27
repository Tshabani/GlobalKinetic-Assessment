using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Assessment.GlobalKinetic.Configuration;

namespace Assessment.GlobalKinetic.Web.Host.Startup
{
    [DependsOn(
       typeof(GlobalKineticWebCoreModule))]
    public class GlobalKineticWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GlobalKineticWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GlobalKineticWebHostModule).GetAssembly());
        }
    }
}
