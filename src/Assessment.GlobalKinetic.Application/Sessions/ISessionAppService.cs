using System.Threading.Tasks;
using Abp.Application.Services;
using Assessment.GlobalKinetic.Sessions.Dto;

namespace Assessment.GlobalKinetic.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
