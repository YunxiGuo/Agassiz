using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Agassiz.Configuration;

namespace Agassiz.Web.Host.Startup
{
    [DependsOn(
       typeof(AgassizWebCoreModule))]
    public class AgassizWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AgassizWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgassizWebHostModule).GetAssembly());
        }
    }
}
