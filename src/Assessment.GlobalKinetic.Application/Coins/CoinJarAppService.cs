using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.UI;
using Assessment.GlobalKinetic.Coins.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.GlobalKinetic.Coins
{

    [AbpAuthorize]
    //[ApiVersion("1")]
    //[Route("api/v{version:apiVersion}/application/[controller]")]
    public class CoinJarAppService : ICoinJarAppService
    {
        private readonly IRepository<Coin, Guid> _coinRepository;
        private readonly IMapper _objectMapper;
        public CoinJarAppService(IRepository<Coin, Guid> coinRepository, IMapper objectMapper)
        {
            _coinRepository = coinRepository;
            _objectMapper = objectMapper;
        }

        /// <summary>
        /// This function is used to create a coin's record in the db
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CoinResponse> AddCoin(CoinInput input)
        {
            try
            {
                var coin = new Coin() { Id = Guid.NewGuid() };
                _objectMapper.Map(input, coin);

                var newCoinn = await _coinRepository.InsertAsync(coin);

                return new CoinResponse
                {
                    Id = newCoinn.Id,
                    Amount = newCoinn.Amount,
                    Volume = newCoinn.Volume
                };
            }
            catch (Exception Ex)
            {
                throw new UserFriendlyException(Ex.Message);
            }
        }

        /// <summary>
        /// This function is used to get the sum of all the Amounts in our Db
        /// </summary>
        /// <returns></returns>
        public async Task<decimal> GetTotalAmount()
        {           
            try
            {
                var amounts = await _coinRepository.GetAll().Select(r => r.Amount).ToListAsync();
                return (decimal)amounts.Sum();
            }
            catch (Exception Ex)
            {
                throw new UserFriendlyException(Ex.Message);
            }
        }

        /// <summary>
        /// This function is used to delete all the coins in our db and it makes use of the soft delete concept
        /// </summary>
        /// <returns></returns>
        public async Task<DeleteCoinsResponse> Reset()
        {
            try
            {
                var coinIds = await _coinRepository.GetAll().Select(r => r.Id).ToListAsync();

                if (!coinIds.Any())
                {
                    throw new UserFriendlyException("There was no coins found in the Database.");
                }

                foreach(var coinId in coinIds)
                {
                    _coinRepository.Delete(coinId);
                }

                return new DeleteCoinsResponse()
                {
                    Success = true
                };
            }
            catch (Exception Ex)
            {
                throw new UserFriendlyException(Ex.Message);
            }
        }
    }
}
