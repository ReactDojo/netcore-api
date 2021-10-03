using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tripdate
    {
        public int Tripnum { get; set; }
        public DateTime Tripdate1 { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Arrivettime { get; set; }
        public DateTime? Leavetime { get; set; }
        public DateTime? Endtime { get; set; }
    }
}
