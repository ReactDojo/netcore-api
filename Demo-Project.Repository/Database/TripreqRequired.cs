using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class TripreqRequired
    {
        public int Id { get; set; }
        public bool RequestDateRequired { get; set; }
        public bool FundRequired { get; set; }
        public bool CustomerRequired { get; set; }
        public bool ContactReq { get; set; }
        public bool DestinationReq { get; set; }
        public bool DepdateReq { get; set; }
        public bool DeptimeReq { get; set; }
        public bool RetdateReq { get; set; }
        public bool RettimeReq { get; set; }
        public bool ArrivetimeReq { get; set; }
        public bool LeavetimeReq { get; set; }
        public bool EstmileReq { get; set; }
        public bool EsttimeReq { get; set; }
        public bool NumstudentsReq { get; set; }
        public bool NumadultsReq { get; set; }
        public bool NumwheelReq { get; set; }
        public bool PurposeReq { get; set; }
        public bool DestspecReq { get; set; }
        public bool CustspecReq { get; set; }
        public bool TripcomReq { get; set; }
        public bool PoReq { get; set; }
        public bool TripcatReq { get; set; }
        public bool InttripnumReq { get; set; }
        public bool GradeReq { get; set; }
        public bool InvoiceCommentReq { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
