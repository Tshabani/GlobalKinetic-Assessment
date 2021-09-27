using Abp.AutoMapper;

namespace Assessment.GlobalKinetic.Coins.Dto
{
    [AutoMap(typeof(Coin))]
    public class CoinInput
    {
        public decimal? Amount { get; set; }
        public decimal? Volume { get; set; }
    }
}
