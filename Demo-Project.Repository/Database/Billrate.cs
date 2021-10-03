using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Billrate
    {
        public short Billrate1 { get; set; }
        public string Bratedesc { get; set; }
        public float? Milerate { get; set; }
        public float? Hourrate { get; set; }
        public float? Waitrate { get; set; }
        public float? Otwaitrate { get; set; }
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
        public float? Minhours { get; set; }
        public float? Minmiles { get; set; }
        public float? Minamount { get; set; }
        public string Billinst { get; set; }
        public short? Emprate { get; set; }
        public float? Hourstep { get; set; }
        public float? Milestep { get; set; }
        public float? Hourrate2 { get; set; }
        public float? Milerate2 { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
