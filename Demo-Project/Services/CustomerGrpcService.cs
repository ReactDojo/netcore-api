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
    public class CustomerGrpcService: CustomerData.CustomerDataBase
    {
        private readonly ILogger<CustomerService> _logger;
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;
        public CustomerGrpcService(ILogger<CustomerService> logger, IMapper mapper, ICustomerService customerService)
        {
            _logger = logger;
            _mapper = mapper;
            _customerService = customerService;
        }

        public override async Task GetAllCustomers(GetAllCustomerRequest request, IServerStreamWriter<GetAllCustomerResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetAllCustomers");

                var data = await _customerService.GetAsync();
                var dataCount = data.Count;

                for (var i = 0; i < dataCount; i++)
                {
                    var item = data[i];

                    await responseStream.WriteAsync(new GetAllCustomerResponse
                    {
                        Customer = item.Customer1 ?? "",
                        CustName = item.Custname ?? ""
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
