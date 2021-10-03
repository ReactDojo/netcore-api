using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Empphoneaddr
    {
        public int Phoneaddrid { get; set; }
        public int Empnum { get; set; }
        public string Description { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
        public bool? Active { get; set; }
        public DateTime? Statuschgdt { get; set; }
        public string Email { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
