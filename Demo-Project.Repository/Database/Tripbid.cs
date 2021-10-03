using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tripbid
    {
        public int Bidnum { get; set; }
        public int Tripnum { get; set; }
        public int Empnum { get; set; }
        public int Bidamt { get; set; }
        public DateTime? Requestdate { get; set; }
        public string Status { get; set; }
        public DateTime? Changedate { get; set; }
    }
}
