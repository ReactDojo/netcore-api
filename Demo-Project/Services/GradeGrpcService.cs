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
    public class GradeGrpcService : GradeData.GradeDataBase
    {
        private readonly ILogger<GradeService> _logger;
        private readonly IMapper _mapper;
        private readonly IGradeService _Service;
        public GradeGrpcService(ILogger<GradeService> logger, IMapper mapper, IGradeService service)
        {
            _logger = logger;
            _mapper = mapper;
            _Service = service;
        }

        public override async Task GetAllGrades(GetAllGradeRequest request, IServerStreamWriter<GetAllGradeResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetAllGrades");

                var data = await _Service.GetAsync();
                var dataCount = data.Count;

                for (var i = 0; i < dataCount; i++)
                {
                    var item = data[i];

                    await responseStream.WriteAsync(new GetAllGradeResponse
                    {
                        Grade = item.Grade1 ?? "",
                        Description = item.Description ?? ""
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
