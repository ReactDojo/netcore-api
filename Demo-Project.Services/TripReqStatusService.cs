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
using Demo_Project.Domain.Entities;

namespace Demo_Project.Services
{
    public class TripReqStatusService : DTO, ITripReqStatusService
    {
        public ITripsReqStatusRepository _Repository;
        private readonly ILogger<EFTripsReqStatusRepository> _logger;

        public TripReqStatusService(ILogger<EFTripsReqStatusRepository> logger)
        {
            _logger = logger;
            _Repository = new EFTripsReqStatusRepository();
        }


        public async Task<List<TripreqstatusEntity>> GetAsync()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Tripreqstatus, TripreqstatusEntity>());
                var mapper = config.CreateMapper();

                var repo = await _Repository.GetAsync();
                var entity = mapper.Map<List<TripreqstatusEntity>>(repo);

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
