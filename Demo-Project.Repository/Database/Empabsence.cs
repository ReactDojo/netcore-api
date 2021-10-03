using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Empabsence
    {
        public int Empnum { get; set; }
        public string Absencecd { get; set; }
        public float? Maxhrs { get; set; }
        public float? Consumedhrs { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
