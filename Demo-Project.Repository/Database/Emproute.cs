using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Emproute
    {
        public int Routenum { get; set; }
        public int Empnum { get; set; }
        public short? Daynum { get; set; }
        public string Routeday { get; set; }
        public short? Tract { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public float? Routetime { get; set; }
        public string Routedesc { get; set; }
        public bool? Keeproute { get; set; }
        public DateTime Createdate { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Changedate { get; set; }
        public string Userchange { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
