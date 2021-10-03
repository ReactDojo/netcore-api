using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class CustomerDestination
    {
        public string Custnum { get; set; }
        public int Destination { get; set; }
        public float? Miles { get; set; }
        public float? Hours { get; set; }
        public float? Amount { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
