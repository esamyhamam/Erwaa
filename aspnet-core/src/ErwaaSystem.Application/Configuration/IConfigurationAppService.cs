using ErwaaSystem.Configuration.Dto;
using System.Threading.Tasks;

namespace ErwaaSystem.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
