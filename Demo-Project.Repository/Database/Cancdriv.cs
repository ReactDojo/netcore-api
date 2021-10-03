using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Cancdriv
    {
        public int Empnum { get; set; }
        public int Tripnum { get; set; }
        public string Schedule { get; set; }
        public DateTime Candate { get; set; }
        public int? Reptripnum { get; set; }
        public DateTime? Repdate { get; set; }
    }
}
