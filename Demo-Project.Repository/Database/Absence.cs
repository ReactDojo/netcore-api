using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Absence
    {
        public string Absencecd { get; set; }
        public string Description { get; set; }
        public bool? Dailyot { get; set; }
        public bool? Weeklyot { get; set; }
        public string ActivityCd { get; set; }
        public float? Maxhrs { get; set; }
        public int? RemaininghrsWarning { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
