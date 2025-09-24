using Abp.Application.Services;
using ErwaaSystem.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace ErwaaSystem.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
