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
    public class TripReqRequiredGrpService : TripReqRequiredData.TripReqRequiredDataBase
    {
        private readonly ILogger<TripReqRequiredService> _logger;
        private readonly IMapper _mapper;
        private readonly ITripReqRequiredService _tripReqRequiredService;

        public TripReqRequiredGrpService(ILogger<TripReqRequiredService> logger, IMapper mapper, ITripReqRequiredService tripReqRequiredService)
        {
            _logger = logger;
            _mapper = mapper;
            _tripReqRequiredService = tripReqRequiredService;
        }

        public override async Task GetTripsReqRequired(GetTripsReqRequiredRequest request, IServerStreamWriter<GetTripsReqRequiredResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetTrips");

                var tripData = await _tripReqRequiredService.GetAsync();
                var tripDataCount = tripData.Count;

                var dataLimit = request.DataLimit > tripDataCount ? tripDataCount : request.DataLimit;

                for (var i = 0; i <= dataLimit - 1; i++)
                {
                    var item = tripData[i];

                    await responseStream.WriteAsync(new GetTripsReqRequiredResponse
                    {
                            //Id = item.Id,
                            //RequestDateRequired = item.RequestDateRequired,
                            //FundRequired = item.FundRequired,
                            //CustomerRequired = item.CustomerRequired,
                            //ContactReq = item.ContactReq,
                            //DestinationReq = item.DestinationReq,
                            //DepdateReq = item.DepdateReq,
                            //DeptimeReq = item.DeptimeReq,
                            //RetdateReq = item.RetdateReq,
                            //RettimeReq = item.RettimeReq,
                            //ArrivetimeReq = item.ArrivetimeReq,
                            //LeavetimeReq = item.LeavetimeReq,
                            //EstmileReq = item.EstmileReq,
                            //EsttimeReq = item.EsttimeReq,
                            //NumstudentsReq = item.NumstudentsReq,
                            //NumadultsReq = item.NumadultsReq,
                            //NumwheelReq = item.NumwheelReq,
                            //PurposeReq = item.PurposeReq,
                            //DestspecReq = item.DestspecReq,
                            //CustspecReq = item.CustspecReq,
                            //TripcomReq = item.TripcomReq,
                            //PoReq = item.PoReq,
                            //TripcatReq = item.TripcatReq,
                            //InttripnumReq = item.InttripnumReq,
                            //GradeReq = item.GradeReq,
                            //InvoiceCommentReq = item.InvoiceCommentReq,
                            
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


        //public override async Task<GetAllTripsReqRequiredResponse> GetAllTripsReqRequiredUnary(GetAllTripsReqRequiredRequest request, IServerStreamWriter<ProjectReply> responseStream, ServerCallContext context)
        //{
        //    try
        //    {
        //        _logger.LogInformation("Incoming request for GetTrips");

        //        var tripData = await _tripReqRequiredService.GetAsync();
        //        var tripDataCount = tripData.Count;


        //        GetAllTripsReqResponse response = new GetAllTripsReqResponse();

        //        for (var i = 0; i < tripDataCount; i++)
        //        {
        //            var item = tripData[i];

        //            Trip tripo = new Trip();

        //            //await responseStream.WriteAsync(new GetAllTripsReqRequiredResponse
        //            //{

        //            //    trip0.Id = item.Id,
        //            //    trip0.RequestDateRequired = item.RequestDateRequired,
        //            //    trip0.FundRequired = item.FundRequired,
        //            //    trip0.CustomerRequired = item.CustomerRequired,
        //            //    trip0.ContactReq = item.ContactReq,
        //            //    trip0.DestinationReq = item.DestinationReq,
        //            //    trip0.DepdateReq = item.DepdateReq,
        //            //    trip0.DeptimeReq = item.DeptimeReq,
        //            //    trip0.RetdateReq = item.RetdateReq,
        //            //    trip0.RettimeReq = item.RettimeReq,
        //            //    trip0.ArrivetimeReq = item.ArrivetimeReq,
        //            //    trip0.LeavetimeReq = item.LeavetimeReq,
        //            //    trip0.EstmileReq = item.EstmileReq,
        //            //    trip0.EsttimeReq = item.EsttimeReq,
        //            //    trip0.NumstudentsReq = item.NumstudentsReq,
        //            //    trip0.NumadultsReq = item.NumadultsReq,
        //            //    trip0.NumwheelReq = item.NumwheelReq,
        //            //    trip0.PurposeReq = item.PurposeReq,
        //            //    trip0.DestspecReq = item.DestspecReq,
        //            //    trip0.CustspecReq = item.CustspecReq,
        //            //    trip0.TripcomReq = item.TripcomReq,
        //            //    trip0.PoReq = item.PoReq,
        //            //    trip0.TripcatReq = item.TripcatReq,
        //            //    trip0.InttripnumReq = item.InttripnumReq,
        //            //    trip0.GradeReq = item.GradeReq,
        //            //    trip0.InvoiceCommentReq = item.InvoiceCommentReq,

        //            //});

        //            response.Trips.Add(tripo);
        //        }

        //        Metadata meta = new Metadata();
        //        meta.Add("Grpc-Status", Status.DefaultSuccess.ToString());

        //        await context.WriteResponseHeadersAsync(meta);
        //        context.Status = Status.DefaultSuccess;
        //        return await Task.FromResult(response);
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, "Error occurred");
        //        throw;
        //    }
        //}
    }
}
