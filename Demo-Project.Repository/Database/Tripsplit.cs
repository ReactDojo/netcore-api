using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tripsplit
    {
        public int Recid { get; set; }
        public int? Tripnum { get; set; }
        public string Customer { get; set; }
        public string Fund { get; set; }
        public float? Splitperc { get; set; }
        public float? Splitlimitamount { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
