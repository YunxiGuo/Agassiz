using System.Threading.Tasks;
using Agassiz.Configuration.Dto;

namespace Agassiz.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
