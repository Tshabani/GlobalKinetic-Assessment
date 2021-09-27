using Abp.Application.Services;
using Assessment.GlobalKinetic.Coins.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.GlobalKinetic.Coins
{
    public interface ICoinJarAppService : IApplicationService
    {
        Task<CoinResponse> AddCoin(CoinInput input);
        Task<decimal> GetTotalAmount();
        Task<DeleteCoinsResponse> Reset();
    }
}
