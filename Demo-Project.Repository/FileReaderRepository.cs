using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Demo_Project.Domain.Entities.Location;
using Demo_Project.Domain.Entities;
using Demo_Project.Repository.Interfaces;
using Demo_Project.Repository.Database;

namespace Demo_Project.Repository
{
    public class FileReaderRepository : IFileReaderRepository
    {
        private readonly ILogger<FileReaderRepository> _logger;

        private RootLocation _locationData;

        public FileReaderRepository(ILogger<FileReaderRepository> logger)
        {
            _logger = logger;
        }

        public async Task<RootLocation> ReadAllLinesAsync(string filePath)
        {
            if (_locationData == null)
            {
                _logger.LogInformation($"Reading contents of {filePath} file");

                var locationDataText = await File.ReadAllTextAsync(filePath);
                _locationData = JsonConvert.DeserializeObject<RootLocation>(locationDataText);

                _logger.LogInformation($"{_locationData.Locations.Count} records found");
            }

            return _locationData;
        }
    }
}
