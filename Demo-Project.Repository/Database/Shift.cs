using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Shift
    {
        public string Shift1 { get; set; }
        public string Description { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
