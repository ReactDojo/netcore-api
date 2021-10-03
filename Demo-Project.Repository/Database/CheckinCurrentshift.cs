using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class CheckinCurrentshift
    {
        public int Id { get; set; }
        public int? Empnum { get; set; }
        public DateTime? Trandate { get; set; }
        public string Shift { get; set; }
        public string Description { get; set; }
        public bool? In { get; set; }
        public DateTime? TimeScheduled { get; set; }
        public DateTime? TimeIn { get; set; }
        public short? MinutesLate { get; set; }
        public string EmpMessage { get; set; }
        public string DistrictMessage { get; set; }
        public bool? Confirm { get; set; }
        public string CreateUser { get; set; }
        public string CheckinSource { get; set; }
        public string AdminNote { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
