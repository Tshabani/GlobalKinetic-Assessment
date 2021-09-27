using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Assessment.GlobalKinetic.Configuration.Dto;

namespace Assessment.GlobalKinetic.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GlobalKineticAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
