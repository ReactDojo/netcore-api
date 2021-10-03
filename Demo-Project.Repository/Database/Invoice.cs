using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Invoice
    {
        public string InvoiceId { get; set; }
        public string TemplateDesc { get; set; }
        public bool? ShowAddr { get; set; }
        public bool? ShowLogo { get; set; }
        public bool? ToplineShow { get; set; }
        public bool? InvoiceShow { get; set; }
        public string InvoiceLabel { get; set; }
        public bool? TopinvoiceShow { get; set; }
        public string TopinvoiceLabel { get; set; }
        public bool? EstimateShow { get; set; }
        public string EstimateLabel { get; set; }
        public bool InvDateShow { get; set; }
        public string InvDateLabel { get; set; }
        public bool EstDateShow { get; set; }
        public string EstDateLabel { get; set; }
        public bool? PrefixShow { get; set; }
        public string PrefixLabel { get; set; }
        public bool FundShow { get; set; }
        public string FundLabel { get; set; }
        public bool CustomerShow { get; set; }
        public string CustomerLabel { get; set; }
        public bool? PickcustShow { get; set; }
        public string PickcustLabel { get; set; }
        public bool PoShow { get; set; }
        public string PoLabel { get; set; }
        public bool ContactShow { get; set; }
        public string ContactLabel { get; set; }
        public bool? PurposeShow { get; set; }
        public string PurposeLabel { get; set; }
        public bool? InternalShow { get; set; }
        public string InternalLabel { get; set; }
        public bool? GradeShow { get; set; }
        public string GradeLabel { get; set; }
        public bool? PhoneShow { get; set; }
        public string PhoneLabel { get; set; }
        public bool? DepdateShow { get; set; }
        public string DepdateLabel { get; set; }
        public bool? DestShow { get; set; }
        public string DestLabel { get; set; }
        public bool ShowInvsec1 { get; set; }
        public bool ShowInvsec2 { get; set; }
        public bool ShowInvsec3 { get; set; }
        public bool ShowInvsec4 { get; set; }
        public bool ShowInvsec1Est { get; set; }
        public bool ShowInvsec2Est { get; set; }
        public bool ShowInvsec3Est { get; set; }
        public bool? ChargeLine1Show { get; set; }
        public string ChargeLineLabel { get; set; }
        public bool? ChargeLine2Show { get; set; }
        public bool? TotalShow { get; set; }
        public string TotalLabel { get; set; }
        public bool? DistBillCommentShow { get; set; }
        public bool? CustBillCommentShow { get; set; }
        public bool? FormatCommentShow { get; set; }
        public string FormatComment { get; set; }
        public bool? InvoiceComment1Show { get; set; }
        public bool? DistnameBottomShow { get; set; }
        public bool? DistaddBottomShow { get; set; }
        public bool? DistphoneBottomShow { get; set; }
        public string DistphoneLabel { get; set; }
        public bool? TearlineShow { get; set; }
        public string TearlineLabel { get; set; }
        public bool? TripnumBottomShow { get; set; }
        public string TripnumBottomLabel { get; set; }
        public bool? TripdateBottomShow { get; set; }
        public string TripdateBottomLabel { get; set; }
        public bool? CustomerBottomShow { get; set; }
        public string CustomerBottomLabel { get; set; }
        public bool? TripamountBottomShow { get; set; }
        public string TripamountBottomLabel { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
