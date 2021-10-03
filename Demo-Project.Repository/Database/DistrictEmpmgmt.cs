using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class DistrictEmpmgmt
    {
        public int Id { get; set; }
        public string Usercapt6 { get; set; }
        public string Usercapt7 { get; set; }
        public string Usercapt8 { get; set; }
        public string Usercapt9 { get; set; }
        public string Usercapt10 { get; set; }
        public string Userdatecapt3 { get; set; }
        public string Userdatecapt4 { get; set; }
        public string Userdatecapt5 { get; set; }
        public string Accusercapt1 { get; set; }
        public string Accusercapt2 { get; set; }
        public string Accusercapt3 { get; set; }
        public string Accusercapt4 { get; set; }
        public string Accusercapt5 { get; set; }
        public string Accusercapt6 { get; set; }
        public string Accusercapt7 { get; set; }
        public string Accuserdatecapt1 { get; set; }
        public string Accuserdatecapt2 { get; set; }
        public short? PrepTime { get; set; }
        public short? CriticalLate { get; set; }
        public string LateWarningSound { get; set; }
        public string CriticalWarningSound { get; set; }
        public string CheckinMessage { get; set; }
        public DateTime? MessageBeginDate { get; set; }
        public DateTime? MessageEndDate { get; set; }
        public DateTime? MessageBeginTime { get; set; }
        public DateTime? MessageEndTime { get; set; }
        public int? Lastbatchid { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
