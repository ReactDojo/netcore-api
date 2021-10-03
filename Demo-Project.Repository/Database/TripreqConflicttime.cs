using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class TripreqConflicttime
    {
        public int Routenum { get; set; }
        public short? Daynum { get; set; }
        public string Routeday { get; set; }
        public DateTime Starttime1 { get; set; }
        public DateTime Endtime1 { get; set; }
        public DateTime? Starttime2 { get; set; }
        public DateTime? Endtime2 { get; set; }
        public DateTime? Starttime3 { get; set; }
        public DateTime? Endtime3 { get; set; }
    }
}
