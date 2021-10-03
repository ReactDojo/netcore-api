using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tripleg
    {
        public int Legid { get; set; }
        public int? Tripnum { get; set; }
        public string Starttype { get; set; }
        public string Startid { get; set; }
        public string Startname { get; set; }
        public string Startadd1 { get; set; }
        public string Startadd2 { get; set; }
        public string Startcity { get; set; }
        public string Startstate { get; set; }
        public string Startzip { get; set; }
        public string Endtype { get; set; }
        public string Endid { get; set; }
        public string Endname { get; set; }
        public string Endadd1 { get; set; }
        public string Endadd2 { get; set; }
        public string Endcity { get; set; }
        public string Endstate { get; set; }
        public string Endzip { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Arrivetime { get; set; }
        public DateTime? Leavetime { get; set; }
        public DateTime? Endtime { get; set; }
        public float? Esttime { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
