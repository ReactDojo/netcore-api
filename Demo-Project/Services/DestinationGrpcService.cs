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
        private readonly IDestinationService _DestinationService;
        public DestinationGrpcService(ILogger<DestinationService> logger, IMapper mapper, IDestinationService service)
        {
            _logger = logger;
            _mapper = mapper;
            _DestinationService = service;
        }

        //public override async Task GetAllDestinations(GetAllDestinationRequest request, IServerStreamWriter<GetAllDestinationResponse> responseStream, ServerCallContext context)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Incoming request for GetAllDestinations");

        //        var data = await _Service.GetAsync();
        //        var dataCount = data.Count;

        //        for (var i = 0; i < dataCount; i++)
        //        {
        //            var item = data[i];

        //            await responseStream.WriteAsync(new GetAllDestinationResponse
        //            {
        //                Destination = item.Destination1,
        //                DestDesc = item.Destdesc ?? ""
        //            });
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, "Error occurred");
        //        throw;
        //    }

        //    var headers = context.GetHttpContext().Request.Headers;

        //    await Task.CompletedTask;
        //}
        public override async Task<GetAllDestinationResponse> GetAllDestinationsUnary(GetAllDestinationRequest request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetAllDestinationsUnary");

                var data = await _DestinationService.GetAsync();
                var dataCount = data.Count;

                GetAllDestinationResponse response = new GetAllDestinationResponse();

                for (var i = 0; i < dataCount; i++)
                {
                    var item = data[i];

                    Destination destinationo = new Destination();

                    destinationo.Destination_ = Convert.ToString(item.Destination1);
                    destinationo.DestDesc = item.Destdesc;

                    response.Destinations.Add(destinationo);
                }

                //convert to json
                //var output = JsonConvert.SerializeObject(data);

                //context.Status.StatusCode = Grpc.Core.StatusCode.OK;//Status = StatusCode.OK;
                // context.
                Metadata meta = new Metadata();
                meta.Add("Grpc-Status", Status.DefaultSuccess.ToString());

                await context.WriteResponseHeadersAsync(meta);
                context.Status = Status.DefaultSuccess;
                return await Task.FromResult(response);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Error occurred");
                throw;
            }
        }
    }
}
