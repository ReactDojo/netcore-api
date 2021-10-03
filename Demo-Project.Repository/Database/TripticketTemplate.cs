using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class TripticketTemplate
    {
        public string TicketId { get; set; }
        public string TemplateDesc { get; set; }
        public bool? DistrictShow { get; set; }
        public bool? TripnumShow { get; set; }
        public string TripnumLabel { get; set; }
        public bool? ReplaceTripShow { get; set; }
        public string ReplaceTripLabel { get; set; }
        public bool? InternalShow { get; set; }
        public string InternalCaption { get; set; }
        public bool? DriverShow { get; set; }
        public string DriverCaption { get; set; }
        public bool? VehicleShow { get; set; }
        public string VehicleCaption { get; set; }
        public bool? VtypeShow { get; set; }
        public bool? DepdateShow { get; set; }
        public string DepdateLabel { get; set; }
        public bool? DeptimeShow { get; set; }
        public string DeptimeCaption { get; set; }
        public bool? ArriveShow { get; set; }
        public string ArriveCaption { get; set; }
        public bool? CustnameShow { get; set; }
        public string CustnameCaption { get; set; }
        public bool? ContactShow { get; set; }
        public string ContactCaption { get; set; }
        public bool? CustaddShow { get; set; }
        public string CustaddCaption { get; set; }
        public bool? DropretShow { get; set; }
        public string DropretMessage { get; set; }
        public bool? ShuttleShow { get; set; }
        public string ShuttleMessage { get; set; }
        public bool? MultiShow { get; set; }
        public string MultiMessage { get; set; }
        public bool? DestdescShow { get; set; }
        public string DestdescCaption { get; set; }
        public bool? DestaddShow { get; set; }
        public string DestaddCaption { get; set; }
        public bool? GradeShow { get; set; }
        public string GradeCaption { get; set; }
        public bool? RettimeShow { get; set; }
        public string RettimeCaption { get; set; }
        public bool? LeaveShow { get; set; }
        public string LeaveCaption { get; set; }
        public bool? RetdateShow { get; set; }
        public string RetdateCaption { get; set; }
        public bool? FundShow { get; set; }
        public string FundCaption { get; set; }
        public bool? PurposeShow { get; set; }
        public string PurposeCaption { get; set; }
        public bool? PassengerShow { get; set; }
        public string PassengerCaption { get; set; }
        public bool? DisabledShow { get; set; }
        public string DisabledCaption { get; set; }
        public bool? CategoryShow { get; set; }
        public string CategoryCaption { get; set; }
        public bool? EstmilesShow { get; set; }
        public string EstmilesCaption { get; set; }
        public bool? EsthoursShow { get; set; }
        public string EsthoursCaption { get; set; }
        public bool? AlldriversShow { get; set; }
        public string AlldriversCaption { get; set; }
        public bool? CustspecShow { get; set; }
        public string CustspecCaption { get; set; }
        public bool? DestspecShow { get; set; }
        public string DestspecCaption { get; set; }
        public bool? UserShow { get; set; }
        public byte[] User { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
