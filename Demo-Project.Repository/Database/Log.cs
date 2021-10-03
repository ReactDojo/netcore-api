using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Log
    {
        public int Id { get; set; }
        public int Tripnum { get; set; }
        public int Empnum { get; set; }
        public string Vehicle { get; set; }
        public DateTime Logdate { get; set; }
        public string Schedule { get; set; }
        public string Sourceroutine { get; set; }
        public string Sourcelist { get; set; }
        public string User { get; set; }
        public int? Massjobnum { get; set; }
        public short Activitycode { get; set; }
        public string Description { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
