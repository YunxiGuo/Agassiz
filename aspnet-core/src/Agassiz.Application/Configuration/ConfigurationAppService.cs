using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Agassiz.Configuration.Dto;

namespace Agassiz.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AgassizAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
