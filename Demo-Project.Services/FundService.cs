using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Text;
using AutoMapper;

using Demo_Project.Repository;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;
using Demo_Project.Services.Interfaces;
using System.Threading.Tasks;

namespace Demo_Project.Services
{
    public class FundService: DTO, IFundService
    {
        public IFundRepository _Repository;
        private readonly ILogger<EFFundRepository> _logger;

        public FundService(ILogger<EFFundRepository> logger)
        {
            _logger = logger;
            _Repository = new EFFundRepository();
        }


        public async Task<List<FundEntity>> GetAsync()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Fund, FundEntity>());
                var mapper = config.CreateMapper();

                var repo = await _Repository.GetAsync();
                var entity = mapper.Map<List<FundEntity>>(repo);

                return entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }
    }
}
