using System;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using DemoProject.Web.Protobufs.V1;
using Demo_Project.Services;
using Demo_Project.Services.Interfaces;
using Google.Protobuf.WellKnownTypes;
using Demo_Project.Domain.Entities;

namespace DemoProject.Web.Services
{

    public class TripsRequestGrpcService : TripsReqData.TripsReqDataBase
    {
        private readonly ILogger<TripReqService> _logger;
        private readonly IMapper _mapper;
        private readonly ITripReqService _tripReqService;

        public TripsRequestGrpcService(ILogger<TripReqService> logger, IMapper mapper, ITripReqService tripReqService)
        {
            _logger = logger;
            _mapper = mapper;
            _tripReqService = tripReqService;
        }

        public override async Task GetTripsReq(GetTripsReqRequest request, IServerStreamWriter<GetTripsReqResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetTrips");

                var tripData = await _tripReqService.GetAsync();
                var tripDataCount = tripData.Count;

                var dataLimit = request.DataLimit > tripDataCount ? tripDataCount : request.DataLimit;

                for (var i = 0; i <= dataLimit - 1; i++)
                {
                    var item = tripData[i];

                    await responseStream.WriteAsync(new GetTripsReqResponse
                    {
                        TripNum = item.Tripnum,
                        //Prefix = item.Prefix ?? "",
                        Billrate = item.Billrate,
                        Reqdate = item.Reqdate.ToString(),
                        Fund = item.Fund ?? "",
                        Customer = item.Customer ?? "",
                        //Location = item.Location ?? "",
                        Billcust = item.Billcust ?? "",
                        Contact = item.Contact ?? "",
                        Destination = item.Destination,
                        Depdate = item.Depdate.ToString(),
                        Deptime = item.Deptime.ToString(),
                        Retdate = item.Retdate.ToString(),
                        Rettime = item.Rettime.ToString(),
                        Arrivetime = item.Arrivetime.ToString(),
                        Leavetime = item.Leavetime.ToString(),
                        Estmile = item.Estmile,
                        Esttime = item.Esttime,
                        Numstudents = item.Numstudents,
                        Numadults = item.Numadults,
                        Numhand = item.Numhand,
                        Purpose = item.Purpose ?? "",
                        Destspec = item.Destspec ?? "",
                        Outoftown = item.Outoftown,
                        Schedule = item.Schedule ?? "",
                        Schedule2 = item.Schedule2 ?? "",
                        Schedule3 = item.Schedule3 ?? "",
                        Schedule4 = item.Schedule4 ?? "",
                        Schedule5 = item.Schedule5 ?? "",
                        Calcnumdrivers = item.Calcnumdrivers,
                        Type = item.Type ?? "",
                        Numtype = item.Numtype,
                        Capacity = item.Capacity ?? "",
                        Addltype = item.Addltype ?? "",
                        Numaddl = item.Numaddl,
                        //Bill = item.Bill,
                        //Custspec = item.Custspec ?? "",
                        //Assigned = item.Assigned,
                        //Billed = item.Billed,
                        //Billdate = item.Billdate.ToString(),
                        //Canceled = item.Canceled,
                        //Candate = item.Candate.ToString(),
                        //Numveh = item.Numveh,
                        Dropret = item.Dropret,
                        Tripcom = item.Tripcom ?? "",
                        Autoassign = item.Autoassign,
                        Po = item.Po ?? "",
                        Tripcat = item.Tripcat ?? "",
                        Inttripnum = item.Inttripnum ?? "",
                        Tripreqnum = item.Tripnum,
                        Amount1 = item.Amount1,
                        Amount2 = item.Amount2,
                        Amount3 = item.Amount3,
                        Amount4 = item.Amount4,
                        Amount5 = item.Amount5,
                        Amounttxt1 = item.Amounttxt1 ?? "",
                        Amounttxt2 = item.Amounttxt2 ?? "",
                        Amounttxt3 = item.Amounttxt3 ?? "",
                        Amounttxt4 = item.Amounttxt4 ?? "",
                        Amounttxt5 = item.Amounttxt5 ?? "",
                        Grade = item.Grade ?? "",
                        Split = item.Split,
                        InvoiceFormat = item.InvoiceFormat ?? "",
                        InvoiceComment1 = item.InvoiceComment1 ?? "",
                        Multidest = item.Multidest,
                        Shuttle = item.Shuttle,
                        TicketFormat = item.TicketFormat ?? "",
                        Numchar = item.Numchar,
                        RequestorEmail = item.RequestorEmail ?? "",
                        AdministratorEmail = item.AdministratorEmail ?? "",
                        ApproverEmail = item.ApproverEmail ?? "",
                        //DateEntered = item.DateEntered.ToString(),
                        //UserEntered = item.UserEntered ?? "",
                        //DateLastchanged = item.DateLastchanged.ToString(),
                        //UserLastchanged = item.UserLastchanged ?? "",
                        //User1 = item.User1 ?? "",
                        //User2 = item.User2 ?? "",
                        //Userdate1 = item.Userdate1.ToString(),
                        //Userdate2 = item.Userdate2.ToString(),
                        SsmaTimeStamp = System.Text.Encoding.UTF8.GetString(item.SsmaTimeStamp)

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

        public override async Task<GetAllTripsReqResponse> Create(GetTripsReqRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Incoming request for GetTrips");

            var config = new MapperConfiguration(cfg => cfg.CreateMap<GetTripsReqRequest, TripsreqEntity>());
            var mapper = config.CreateMapper();

            var configTo = new MapperConfiguration(cfg => cfg.CreateMap<TripsreqEntity, GetAllTripsReqResponse>());
            var mapperTo = config.CreateMapper();


            var taskTripService = mapper.Map<TripsreqEntity>(request);

            var tripData = await _tripReqService.AddAsync(taskTripService);

            var tripReqResponse = mapper.Map<GetAllTripsReqResponse>(tripData);


            return tripReqResponse;
        }
            //try
            //{

            //}
            //catch (Exception exception)
            //{
            //    _logger.LogError(exception, "Error occurred");
            //    throw;
            //}
    //var tripDataCount = tripData.Count;

    //var dataLimit = request.DataLimit > tripDataCount ? tripDataCount : request.DataLimit;

    //for (var i = 0; i <= dataLimit - 1; i++)
    //{
    //    var item = tripData[i];

    //}
    //public override async Task<GetAllTripsResponse> GetAllTripsReqReqUnary(GetAllTripsRequest request, ServerCallContext context)
    //{
    //    try
    //    {
    //        _logger.LogInformation("Incoming request for GetTrips");

    //        var tripData = await _tripReqService.GetAsync();
    //        var tripDataCount = tripData.Count;


    //        GetAllTripsResponse response = new GetAllTripsResponse();

    //        for (var i = 0; i < tripDataCount; i++)
    //        {
    //            var item = tripData[i];

    //            Trip tripo = new Trip();

    //            //await responseStream.WriteAsync(new GetAllTripsResponse
    //            //{
    //            tripo.TripNum = item.Tripnum;
    //            //tripo.Prefix = item.Prefix ?? "";
    //            tripo.Billrate = item.Billrate;
    //            tripo.Reqdate = item.Reqdate.ToString();
    //            tripo.Fund = item.Fund ?? "";
    //            tripo.Customer = item.Customer ?? "";
    //            //tripo.Location = item.Location ?? "";
    //            tripo.Billcust = item.Billcust ?? "";
    //            tripo.Contact = item.Contact ?? "";
    //            tripo.Destination = item.Destination;
    //            tripo.Depdate = item.Depdate.ToString();
    //            tripo.Deptime = item.Deptime.ToString();
    //            tripo.Retdate = item.Retdate.ToString();
    //            tripo.Rettime = item.Rettime.ToString();
    //            tripo.Arrivetime = item.Arrivetime.ToString();
    //            tripo.Leavetime = item.Leavetime.ToString();
    //            tripo.Estmile = item.Estmile;
    //            tripo.Esttime = item.Esttime;
    //            tripo.Numstudents = item.Numstudents;
    //            tripo.Numadults = item.Numadults;
    //            tripo.Numhand = item.Numhand;
    //            tripo.Purpose = item.Purpose ?? "";
    //            tripo.Destspec = item.Destspec ?? "";
    //            tripo.Outoftown = item.Outoftown;
    //            tripo.Schedule = item.Schedule ?? "";
    //            tripo.Schedule2 = item.Schedule2 ?? "";
    //            tripo.Schedule3 = item.Schedule3 ?? "";
    //            tripo.Schedule4 = item.Schedule4 ?? "";
    //            tripo.Schedule5 = item.Schedule5 ?? "";
    //            tripo.Calcnumdrivers = item.Calcnumdrivers;
    //            tripo.Type = item.Type ?? "";
    //            tripo.Numtype = item.Numtype;
    //            tripo.Capacity = item.Capacity ?? "";
    //            tripo.Addltype = item.Addltype ?? "";
    //            tripo.Numaddl = item.Numaddl;
    //            // tripo.Bill = item.Bill;
    //            tripo.Custspec = item.Custspec ?? "";
    //            //tripo.Assigned = item.Assigned;
    //            // tripo.Billed = item.Billed;
    //            // tripo.Billdate = item.Billdate.ToString();
    //            // tripo.Canceled = item.Canceled;
    //            // tripo.Candate = item.Candate.ToString();
    //            // tripo.Numveh = item.Numveh;
    //            tripo.Dropret = item.Dropret;
    //            tripo.Tripcom = item.Tripcom ?? "";
    //            tripo.Autoassign = item.Autoassign;
    //            tripo.Po = item.Po ?? "";
    //            tripo.Tripcat = item.Tripcat ?? "";
    //            tripo.Inttripnum = item.Inttripnum ?? "";
    //            //  tripo.Tripreqnum = item.Tripreqnum;
    //            tripo.Amount1 = item.Amount1;
    //            tripo.Amount2 = item.Amount2;
    //            tripo.Amount3 = item.Amount3;
    //            tripo.Amount4 = item.Amount4;
    //            tripo.Amount5 = item.Amount5;
    //            tripo.Amounttxt1 = item.Amounttxt1 ?? "";
    //            tripo.Amounttxt2 = item.Amounttxt2 ?? "";
    //            tripo.Amounttxt3 = item.Amounttxt3 ?? "";
    //            tripo.Amounttxt4 = item.Amounttxt4 ?? "";
    //            tripo.Amounttxt5 = item.Amounttxt5 ?? "";
    //            tripo.Grade = item.Grade ?? "";
    //            tripo.Split = item.Split;
    //            tripo.InvoiceFormat = item.InvoiceFormat ?? "";
    //            tripo.InvoiceComment1 = item.InvoiceComment1 ?? "";
    //            tripo.Multidest = item.Multidest;
    //            tripo.Shuttle = item.Shuttle;
    //            tripo.TicketFormat = item.TicketFormat ?? "";
    //            tripo.Numchar = item.Numchar;
    //            tripo.RequestorEmail = item.RequestorEmail ?? "";
    //            tripo.AdministratorEmail = item.AdministratorEmail ?? "";
    //            tripo.ApproverEmail = item.ApproverEmail ?? "";
    //            //tripo.DateEntered = item.DateEntered.ToString();
    //            //tripo.UserEntered = item.UserEntered ?? "";
    //            //tripo.DateLastchanged = item.DateLastchanged.ToString();
    //            //tripo.UserLastchanged = item.UserLastchanged ?? "";
    //            //tripo.User1 = item.User1 ?? "";
    //            //tripo.User2 = item.User2 ?? "";
    //            //tripo.Userdate1 = item.Userdate1.ToString();
    //            //tripo.Userdate2 = item.Userdate2.ToString();
    //            tripo.SsmaTimeStamp = System.Text.Encoding.UTF8.GetString(item.SsmaTimeStamp);

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
