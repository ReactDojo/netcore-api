using System;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using DemoProject.Web.Protobufs.V1;
using Demo_Project.Services;
using Demo_Project.Services.Interfaces;
using Google.Protobuf.WellKnownTypes;

namespace DemoProject.Web.Services
{
    public class DestinationGrpcService : DestinationData.DestinationDataBase
    {
        private readonly ILogger<DestinationService> _logger;
        private readonly IMapper _mapper;
        private readonly IDestinationService _Service;
        public DestinationGrpcService(ILogger<DestinationService> logger, IMapper mapper, IDestinationService service)
        {
            _logger = logger;
            _mapper = mapper;
            _Service = service;
        }

        public override async Task GetAllDestinations(GetAllDestinationRequest request, IServerStreamWriter<GetAllDestinationResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetAllDestinations");

                var data = await _Service.GetAsync();
                var dataCount = data.Count;

                for (var i = 0; i < dataCount; i++)
                {
                    var item = data[i];

                    await responseStream.WriteAsync(new GetAllDestinationResponse
                    {
                        Destination = item.Destination1,
                        DestDesc = item.Destdesc ?? ""
                    });
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Error occurred");
                throw;
            }

            var headers = context.GetHttpContext().Request.Headers;

            await Task.CompletedTask;
        }
    }
}
