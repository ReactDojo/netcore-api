using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Empref
    {
        public int Empnum { get; set; }
        public int Tripnum { get; set; }
        public string Schedule { get; set; }
        public DateTime Refdate { get; set; }
        public DateTime Depdate { get; set; }
    }
}
