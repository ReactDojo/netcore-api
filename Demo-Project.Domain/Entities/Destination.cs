using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class DestinationEntity
    {
        public int Destination1 { get; set; }
        public string Destdesc { get; set; }
        public string Destcat { get; set; }
        public float? Miles { get; set; }
        public string Destadd1 { get; set; }
        public string Destadd2 { get; set; }
        public string Destcity { get; set; }
        public string Deststate { get; set; }
        public string Destzip { get; set; }
        public string Destspec { get; set; }
        public float? BillAmount { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
