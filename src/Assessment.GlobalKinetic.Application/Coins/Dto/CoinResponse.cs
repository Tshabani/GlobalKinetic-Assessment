using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace Assessment.GlobalKinetic.Coins.Dto
{
    [AutoMap(typeof(Coin))]
    public class CoinResponse : EntityDto<Guid>
    {
        public decimal? Amount { get; set; }
        public decimal? Volume { get; set; }
    }
}
