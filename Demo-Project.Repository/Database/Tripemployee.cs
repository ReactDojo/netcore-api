using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tripemployee
    {
        public int Tripnum { get; set; }
        public int Empnum { get; set; }
        public string Vehicle { get; set; }
        public string Schedule { get; set; }
        public float? Miles { get; set; }
        public float? Hours { get; set; }
        public float? Othours { get; set; }
        public float? Waittime { get; set; }
        public float? Otwaittime { get; set; }
        public float? Hourspaid { get; set; }
        public double? Begod { get; set; }
        public double? Arriveod { get; set; }
        public double? Leaveod { get; set; }
        public double? Endod { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Arrivetime { get; set; }
        public DateTime? Leavetime { get; set; }
        public DateTime? Endtime { get; set; }
        public float? Custmiles { get; set; }
        public float? Custhours { get; set; }
        public float Driverexp { get; set; }
        public DateTime? Postdate { get; set; }
        public int? Bidnum { get; set; }
        public int? Legid { get; set; }
        public bool Addhours { get; set; }
        public string Drivernotes { get; set; }
        public bool? Calcot { get; set; }
        public bool DontCountHrs { get; set; }
        public string Status { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
