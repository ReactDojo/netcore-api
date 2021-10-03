using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Ardetail
    {
        public int Recid { get; set; }
        public int Tripnum { get; set; }
        public string Tranprefix { get; set; }
        public string Trancode { get; set; }
        public DateTime Trandate { get; set; }
        public string Trancust { get; set; }
        public string Tranfund { get; set; }
        public decimal? Tranamt { get; set; }
        public string Checknum { get; set; }
    }
}
