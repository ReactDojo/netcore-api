using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AutoMapper;

using Demo_Project.Services.Interfaces;

using Demo_Project.Repository;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;

using Demo_Project.Domain.Entities.Location;
using Demo_Project.Domain.Entities;


namespace Demo_Project.Services
{
    public class FileReaderService : DTO, IFileReaderService
    {
        public IFileReaderRepository _FileReaderRepository;
        private readonly ILogger<FileReaderRepository> _logger;

        private RootLocation _locationData;

        public FileReaderService()
        {
            _FileReaderRepository = new FileReaderRepository(_logger);
        }
        //call the file respository from here instead of accessing it directly
        public async Task<RootLocationEntity> ReadAllLinesAsync(string filePath)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RootLocation, RootLocationEntity>());
            var mapper = config.CreateMapper();

            var locationRepo = await _FileReaderRepository.ReadAllLinesAsync(filePath);
            //this could essentially just be a list
            var taskLocationEntity = mapper.Map<RootLocationEntity>(locationRepo);

            return taskLocationEntity;

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
