using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Customer
    {
        public string Customer1 { get; set; }
        public string Custname { get; set; }
        public string Custadd1 { get; set; }
        public string Custadd2 { get; set; }
        public string Custcity { get; set; }
        public string Custstate { get; set; }
        public string Custzip { get; set; }
        public string Custphone { get; set; }
        public string Custfax { get; set; }
        public short? Custbillrate { get; set; }
        public string DefaultBillcust { get; set; }
        public string Custdiv { get; set; }
        public string Custspec { get; set; }
        public string Custbillcomm { get; set; }
        public string Custinternalnum { get; set; }
        public string Defaultcap { get; set; }
        public bool? Custbill { get; set; }
        public decimal? Budget { get; set; }
        public float Basehours { get; set; }
        public float Basemiles { get; set; }
        public float Baseamt { get; set; }
        public string RequestorEmail { get; set; }
        public string AdministratorEmail { get; set; }
        public string ApproverEmail { get; set; }
        public string CustDefaultFormat { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public string Chainid { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
