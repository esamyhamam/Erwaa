using Abp.Application.Services;
using ErwaaSystem.Sessions.Dto;
using System.Threading.Tasks;

namespace ErwaaSystem.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
