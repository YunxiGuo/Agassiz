using Abp.Application.Services;
using Agassiz.MultiTenancy.Dto;

namespace Agassiz.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

