using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Reminder
    {
        public string Type { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public short? DueEvery { get; set; }
        public short? WarningPd { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public string Nexttrantype { get; set; }
        public string Autoschedule { get; set; }
        public string Nexttrandtbasedon { get; set; }
        public float? Rqdhr { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
