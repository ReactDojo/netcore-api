﻿using System;
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
    public class TripGrpService : TripData.TripDataBase
    {
        private readonly ILogger<TripService> _logger;
        private readonly IMapper _mapper;
        private readonly ITripService _tripService;

        public TripGrpService(ILogger<TripService> logger, IMapper mapper, ITripService tripService)
        {
            _logger = logger;
            _mapper = mapper;
            _tripService = tripService;
        }

        public override async Task GetTrips(GetTripsRequest request, IServerStreamWriter<GetTripsResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetTrips");

                var tripData = await _tripService.GetAsync();
                var tripDataCount = tripData.Count;

                var dataLimit = request.DataLimit > tripDataCount ? tripDataCount : request.DataLimit;

                for (var i = 0; i <= dataLimit - 1; i++)
                {
                    var item = tripData[i];

                    await responseStream.WriteAsync(new GetTripsResponse
                    {
                        TripNum = item.Tripnum,
                        Prefix = item.Prefix ?? "",
                        Billrate = item.Billrate,
                        Reqdate = item.Reqdate.ToString(),
                        Fund = item.Fund ?? "",
                        Customer = item.Customer ?? "",
                        Location = item.Location ?? "",
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
                        Bill = item.Bill,
                        Custspec = item.Custspec ?? "",
                        Assigned = item.Assigned,
                        Billed = item.Billed,
                        Billdate = item.Billdate.ToString(),
                        Canceled = item.Canceled,
                        Candate = item.Candate.ToString(),
                        Numveh = item.Numveh,
                        Dropret = item.Dropret,
                        Tripcom = item.Tripcom ?? "",
                        Autoassign = item.Autoassign,
                        Po = item.Po ?? "",
                        Tripcat = item.Tripcat ?? "",
                        Inttripnum = item.Inttripnum ?? "",
                        Tripreqnum = item.Tripreqnum,
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
                        DateEntered = item.DateEntered.ToString(),
                        UserEntered = item.UserEntered ?? "",
                        DateLastchanged = item.DateLastchanged.ToString(),
                        UserLastchanged = item.UserLastchanged ?? "",
                        User1 = item.User1 ?? "",
                        User2 = item.User2 ?? "",
                        Userdate1 = item.Userdate1.ToString(),
                        Userdate2 = item.Userdate2.ToString(),
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


        public override async Task GetAllTrips(GetAllTripsRequest request, IServerStreamWriter<GetAllTripsResponse> responseStream, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Incoming request for GetTrips");

                var tripData = await _tripService.GetAsync();
                var tripDataCount = tripData.Count;

                for (var i = 0; i < tripDataCount; i++)
                {
                    var item = tripData[i];

                    await responseStream.WriteAsync(new GetAllTripsResponse
                    {
                        TripNum = item.Tripnum,
                        Prefix = item.Prefix ?? "",
                        Billrate = item.Billrate,
                        Reqdate = item.Reqdate.ToString(),
                        Fund = item.Fund ?? "",
                        Customer = item.Customer ?? "",
                        Location = item.Location ?? "",
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
                        Bill = item.Bill,
                        Custspec = item.Custspec ?? "",
                        Assigned = item.Assigned,
                        Billed = item.Billed,
                        Billdate = item.Billdate.ToString(),
                        Canceled = item.Canceled,
                        Candate = item.Candate.ToString(),
                        Numveh = item.Numveh,
                        Dropret = item.Dropret,
                        Tripcom = item.Tripcom ?? "",
                        Autoassign = item.Autoassign,
                        Po = item.Po ?? "",
                        Tripcat = item.Tripcat ?? "",
                        Inttripnum = item.Inttripnum ?? "",
                        Tripreqnum = item.Tripreqnum,
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
                        DateEntered = item.DateEntered.ToString(),
                        UserEntered = item.UserEntered ?? "",
                        DateLastchanged = item.DateLastchanged.ToString(),
                        UserLastchanged = item.UserLastchanged ?? "",
                        User1 = item.User1 ?? "",
                        User2 = item.User2 ?? "",
                        Userdate1 = item.Userdate1.ToString(),
                        Userdate2 = item.Userdate2.ToString(),
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
    }
}
