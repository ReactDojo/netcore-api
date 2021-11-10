using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Domain.Entities
{
    public partial class TripEntity
    {
        public int Tripnum { get; set; }
        public string Prefix { get; set; }
        public short Billrate { get; set; }
        public DateTime Reqdate { get; set; }
        public string Fund { get; set; }
        public string Customer { get; set; }
        public string Location { get; set; }
        public string Billcust { get; set; }
        public string Contact { get; set; }
        public int Destination { get; set; }
        public DateTime Depdate { get; set; }
        public DateTime Deptime { get; set; }
        public DateTime Retdate { get; set; }
        public DateTime Rettime { get; set; }
        public DateTime Arrivetime { get; set; }
        public DateTime Leavetime { get; set; }
        public float Estmile { get; set; }
        public float Esttime { get; set; }
        public short Numstudents { get; set; }
        public short Numadults { get; set; }
        public short Numhand { get; set; }
        public string Purpose { get; set; }
        public string Destspec { get; set; }
        public bool Outoftown { get; set; }
        public string Schedule { get; set; }
        public string Schedule2 { get; set; }
        public string Schedule3 { get; set; }
        public string Schedule4 { get; set; }
        public string Schedule5 { get; set; }
        public bool Calcnumdrivers { get; set; }
        public string Type { get; set; }
        public short Numtype { get; set; }
        public string Capacity { get; set; }
        public string Addltype { get; set; }
        public short Numaddl { get; set; }
        public bool Bill { get; set; }
        public string Custspec { get; set; }
        public bool Assigned { get; set; }
        public bool Billed { get; set; }
        public DateTime Billdate { get; set; }
        public bool Canceled { get; set; }
        public DateTime Candate { get; set; }
        public short Numveh { get; set; }
        public bool Dropret { get; set; }
        public string Tripcom { get; set; }
        public bool Autoassign { get; set; }
        public string Po { get; set; }
        public string Tripcat { get; set; }
        public string Inttripnum { get; set; }
        public int Tripreqnum { get; set; }
        public float Amount1 { get; set; }
        public float Amount2 { get; set; }
        public float Amount3 { get; set; }
        public float Amount4 { get; set; }
        public float Amount5 { get; set; }
        public string Amounttxt1 { get; set; }
        public string Amounttxt2 { get; set; }
        public string Amounttxt3 { get; set; }
        public string Amounttxt4 { get; set; }
        public string Amounttxt5 { get; set; }
        public string Grade { get; set; }
        public bool Split { get; set; }
        public string InvoiceFormat { get; set; }
        public string InvoiceComment1 { get; set; }
        public bool Multidest { get; set; }
        public bool Shuttle { get; set; }
        public string TicketFormat { get; set; }
        public short Numchar { get; set; }
        public string RequestorEmail { get; set; }
        public string AdministratorEmail { get; set; }
        public string ApproverEmail { get; set; }
        public DateTime DateEntered { get; set; }
        public string UserEntered { get; set; }
        public DateTime DateLastchanged { get; set; }
        public string UserLastchanged { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public DateTime Userdate1 { get; set; }
        public DateTime Userdate2 { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
