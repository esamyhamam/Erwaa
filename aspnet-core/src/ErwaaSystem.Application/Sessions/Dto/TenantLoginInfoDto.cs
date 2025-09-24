using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ErwaaSystem.MultiTenancy;

namespace ErwaaSystem.Sessions.Dto;

[AutoMapFrom(typeof(Tenant))]
public class TenantLoginInfoDto : EntityDto
{
    public string TenancyName { get; set; }

    public string Name { get; set; }
}
