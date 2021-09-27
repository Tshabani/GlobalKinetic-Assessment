using Abp.Application.Services;
using Assessment.GlobalKinetic.MultiTenancy.Dto;

namespace Assessment.GlobalKinetic.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

