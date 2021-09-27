using System.Threading.Tasks;
using Assessment.GlobalKinetic.Configuration.Dto;

namespace Assessment.GlobalKinetic.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
