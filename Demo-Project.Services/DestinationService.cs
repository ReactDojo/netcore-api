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
    public class DestinationService: DTO, IDestinationService
    {
        public IDestinationRepository _Repository;
        private readonly ILogger<EFDestinationRepository> _logger;

        public DestinationService(ILogger<EFDestinationRepository> logger)
        {
            _logger = logger;
            _Repository = new EFDestinationRepository();
        }


        public async Task<List<DestinationEntity>> GetAsync()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Destination, DestinationEntity>());
                var mapper = config.CreateMapper();

                var repo = await _Repository.GetAsync();
                var entity = mapper.Map<List<DestinationEntity>>(repo);

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
