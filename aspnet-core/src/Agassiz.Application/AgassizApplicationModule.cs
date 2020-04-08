using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Agassiz.Authorization;

namespace Agassiz
{
    [DependsOn(
        typeof(AgassizCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgassizApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgassizAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AgassizApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
