using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.IO;
using System;

using AutoMapper;

using Demo_Project.Services.Interfaces;

using Demo_Project.Repository;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;

using Demo_Project.Domain.Entities.Location;
using Demo_Project.Domain.Entities;

namespace Demo_Project.Services
{
    public class LocationService : DTO, ILocationService
    {
        public IFileReaderRepository _FileReaderRepository;
        private readonly ILogger<FileReaderRepository> _logger;

        //private RootLocation _locationData;

        public LocationService(ILogger<FileReaderRepository> logger)
        {
            _logger = logger;
            _FileReaderRepository = new FileReaderRepository(_logger);
        }
        //call the file respository from here instead of accessing it directly
        public async Task<RootLocationEntity> ReadAllLinesAsync(string filePath)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<RootLocation, RootLocationEntity>(); cfg.CreateMap<Location, LocationEntity>();});
             
            try
            { 
                var mapper = config.CreateMapper();

                var locationRepo = await _FileReaderRepository.ReadAllLinesAsync(filePath);
                //this could essentially just be a list
                var taskLocationEntity = mapper.Map<RootLocationEntity>(locationRepo);

                return taskLocationEntity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
           

            //if (_locationData == null)
            //{
            //    _logger.LogInformation($"Reading contents of {filePath} file");

            //    var locationDataText = await File.ReadAllTextAsync(filePath);
            //    _locationData = JsonConvert.DeserializeObject<RootLocation>(locationDataText);

            //    _logger.LogInformation($"{_locationData.Locations.Count} records found");
            //}

            //return _locationData;
        }
    }
}
