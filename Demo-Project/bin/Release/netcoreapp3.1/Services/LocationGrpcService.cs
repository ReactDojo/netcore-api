using System;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using DemoProject.Web.Protobufs.V1;
using Demo_Project.Services;
using Demo_Project.Domain.Entities.Location;
using System.IO;
using Demo_Project.Services.Interfaces;

namespace DemoProject.Web.Services
{
    public class LocationGrpService : LocationData.LocationDataBase
    {
        private readonly ILocationService _locationService;
        private readonly ILogger<LocationService> _logger;

        public LocationGrpService(ILocationService locationService, ILogger<LocationService> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }

        public override async Task GetLocations(GetLocationsRequest request, IServerStreamWriter<GetLocationsResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetLocationData");

                var locationData = await GetLocationData();
                var locationDataCount = locationData.Locations.Count;

                var dataLimit = request.DataLimit > locationDataCount ? locationDataCount : request.DataLimit;

                for (var i = 0; i <= dataLimit - 1; i++)
                {
                    var item = locationData.Locations[i];

                    await responseStream.WriteAsync(new GetLocationsResponse
                    {
                        LatitudeE7 = item.LatitudeE7,
                        LongitudeE7 = item.LongitudeE7
                    });
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Error occurred");
                throw;
            }
        }
        public override async Task GetAllLocations(GetAllLocationsRequest request, IServerStreamWriter<GetAllLocationsResponse> responseStream, ServerCallContext context)
        {
            _logger.LogInformation("Incoming request for GetAllLocationData");

            var locationData = await GetLocationData();
            var locations = locationData.Locations;

            foreach (var item in locations)
            {
                await responseStream.WriteAsync(new GetAllLocationsResponse
                {
                    LatitudeE7 = item.LatitudeE7,
                    LongitudeE7 = item.LongitudeE7
                });
            }
        }
        private async Task<RootLocationEntity> GetLocationData()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = $"{currentDirectory}/Data/Location_History.json";

            var locationData = await _locationService.ReadAllLinesAsync(filePath);

            return locationData;
        }
    }
}
