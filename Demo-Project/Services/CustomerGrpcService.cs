using System;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using DemoProject.Web.Protobufs.V1;
using Demo_Project.Services;
using Demo_Project.Services.Interfaces;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;

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

        //public override async Task<GetAllCustomerResponse> GetAllCustomers(GetAllCustomerRequest request, ServerCallContext context)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Incoming request for GetAllCustomers");

        //        var data = await _customerService.GetAsync();
        //        var dataCount = data.Count;


        //        for (var i = 0; i < dataCount; i++)
        //        {
        //            var item = data[i];

        //            //await responseStream.WriteAsync(
        //            //new GetAllCustomerResponse
        //            //{
        //            //    Customer = item.Customer1 ?? "",
        //            //    CustName = item.Custname ?? ""
        //            //};
        //        }
        //        //convert to json
        //        //var output = JsonConvert.SerializeObject(data);
        //        //GetAllCustomerResponse response = new GetAllCustomerResponse();
        //        //response.

        //        return new GetAllCustomerResponse
        //        {
        //            Customer = "13",
        //            CustName = "Nadim Sayani"
        //        }; 
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, "Error occurred");
        //        throw;
        //    }

        //    var headers = context.GetHttpContext().Request.Headers;

        //    await Task.CompletedTask;
        //}
        public override async Task<GetAllCustomerResponse> GetAllCustomersUnary(GetAllCustomerRequest request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetAllCustomers");

                var data = await _customerService.GetAsync();
                var dataCount = data.Count;

                GetAllCustomerResponse response = new GetAllCustomerResponse();

                for (var i = 0; i < dataCount; i++)
                {
                    var item = data[i];

                    Customer custo = new Customer();

                    custo.CustomerID = item.Customer1;
                    custo.CustName = item.Custname;

                    response.Customers.Add(custo);
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
