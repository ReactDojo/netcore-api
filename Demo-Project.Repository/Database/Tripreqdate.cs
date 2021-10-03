using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tripreqdate
    {
        public int Tripnum { get; set; }
        public DateTime Tripdate { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Arrivettime { get; set; }
        public DateTime? Leavetime { get; set; }
        public DateTime? Endtime { get; set; }
    }
}
