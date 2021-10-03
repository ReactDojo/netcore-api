using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tripsreq
    {
        public int Tripnum { get; set; }
        public short? Billrate { get; set; }
        public DateTime? Reqdate { get; set; }
        public string Fund { get; set; }
        public string Customer { get; set; }
        public string Billcust { get; set; }
        public string Contact { get; set; }
        public int? Destination { get; set; }
        public DateTime? Depdate { get; set; }
        public DateTime? Deptime { get; set; }
        public DateTime? Retdate { get; set; }
        public DateTime? Rettime { get; set; }
        public DateTime? Arrivetime { get; set; }
        public DateTime? Leavetime { get; set; }
        public float? Estmile { get; set; }
        public float? Esttime { get; set; }
        public short? Numstudents { get; set; }
        public short? Numadults { get; set; }
        public short? Numhand { get; set; }
        public string Purpose { get; set; }
        public string Destspec { get; set; }
        public bool? Outoftown { get; set; }
        public string Schedule { get; set; }
        public string Schedule2 { get; set; }
        public string Schedule3 { get; set; }
        public string Schedule4 { get; set; }
        public string Schedule5 { get; set; }
        public bool Calcnumdrivers { get; set; }
        public string Type { get; set; }
        public short? Numtype { get; set; }
        public string Capacity { get; set; }
        public string Addltype { get; set; }
        public short? Numaddl { get; set; }
        public string Custspec { get; set; }
        public bool? Dropret { get; set; }
        public string Tripcom { get; set; }
        public bool Autoassign { get; set; }
        public string Po { get; set; }
        public string Tripcat { get; set; }
        public string Inttripnum { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string StatusComment { get; set; }
        public string Destdesc { get; set; }
        public string Destcat { get; set; }
        public float? Miles { get; set; }
        public string Destadd1 { get; set; }
        public string Destadd2 { get; set; }
        public string Destcity { get; set; }
        public string Deststate { get; set; }
        public string Destzip { get; set; }
        public string Enteredby { get; set; }
        public DateTime? Enterdate { get; set; }
        public int? FieldtripNum { get; set; }
        public float? Amount1 { get; set; }
        public float? Amount2 { get; set; }
        public float? Amount3 { get; set; }
        public float? Amount4 { get; set; }
        public float? Amount5 { get; set; }
        public string Amounttxt1 { get; set; }
        public string Amounttxt2 { get; set; }
        public string Amounttxt3 { get; set; }
        public string Amounttxt4 { get; set; }
        public string Amounttxt5 { get; set; }
        public string Grade { get; set; }
        public bool Split { get; set; }
        public string InvoiceFormat { get; set; }
        public string InvoiceComment1 { get; set; }
        public bool? Multidest { get; set; }
        public bool? Shuttle { get; set; }
        public string TicketFormat { get; set; }
        public short? Numchar { get; set; }
        public string Chainid { get; set; }
        public string RequestorEmail { get; set; }
        public string AdministratorEmail { get; set; }
        public string ApproverEmail { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
