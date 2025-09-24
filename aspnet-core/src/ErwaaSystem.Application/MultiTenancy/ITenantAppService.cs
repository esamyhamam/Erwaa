using Abp.Application.Services;
using ErwaaSystem.MultiTenancy.Dto;

namespace ErwaaSystem.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

