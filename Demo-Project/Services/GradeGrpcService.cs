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
        private readonly IGradeService _gradeService;
        public GradeGrpcService(ILogger<GradeService> logger, IMapper mapper, IGradeService service)
        {
            _logger = logger;
            _mapper = mapper;
            _gradeService = service;
        }

        //public override async Task GetAllGrades(GetAllGradeRequest request, IServerStreamWriter<GetAllGradeResponse> responseStream, ServerCallContext context)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Incoming request for GetAllGrades");

        //        var data = await _Service.GetAsync();
        //        var dataCount = data.Count;

        //        for (var i = 0; i < dataCount; i++)
        //        {
        //            var item = data[i];

        //            await responseStream.WriteAsync(new GetAllGradeResponse
        //            {
        //                Grade = item.Grade1 ?? "",
        //                Description = item.Description ?? ""
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
        public override async Task<GetAllGradeResponse> GetAllGradesUnary(GetAllGradeRequest request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetAllDestinationsUnary");

                var data = await _gradeService.GetAsync();
                var dataCount = data.Count;

                GetAllGradeResponse response = new GetAllGradeResponse();

                for (var i = 0; i < dataCount; i++)
                {
                    var item = data[i];

                    Grade gradeo = new Grade();

                    gradeo.Grade_ = item.Grade1;
                    gradeo.Description = item.Description;

                    response.Grades.Add(gradeo);
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
