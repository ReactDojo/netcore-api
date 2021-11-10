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
    public class FundGrpcService : FundData.FundDataBase
    {
        private readonly ILogger<FundService> _logger;
        private readonly IMapper _mapper;
        private readonly IFundService _FundService;
        public FundGrpcService(ILogger<FundService> logger, IMapper mapper, IFundService service)
        {
            _logger = logger;
            _mapper = mapper;
            _FundService = service;
        }

        //public override async Task GetAllFunds(GetAllFundRequest request, IServerStreamWriter<GetAllFundResponse> responseStream, ServerCallContext context)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Incoming request for GetAllFunds");

        //        var data = await _Service.GetAsync();
        //        var dataCount = data.Count;

        //        for (var i = 0; i < dataCount; i++)
        //        {
        //            var item = data[i];

        //            await responseStream.WriteAsync(new GetAllFundResponse
        //            {
        //                Fund = item.Fund1 ?? "",
        //                FundDesc = item.Funddesc ?? ""
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
        public override async Task<GetAllFundResponse> GetAllFundsUnary(GetAllFundRequest request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetAllCustomers");

                var data = await _FundService.GetAsync();
                var dataCount = data.Count;

                GetAllFundResponse response = new GetAllFundResponse();

                for (var i = 0; i < dataCount; i++)
                {
                    var item = data[i];

                    Fund fundo = new Fund();

                    fundo.Fund_ = item.Fund1;
                    fundo.FundDesc = item.Funddesc;

                    response.Funds.Add(fundo);
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
