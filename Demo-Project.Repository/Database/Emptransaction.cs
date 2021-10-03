using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Emptransaction
    {
        public int Id { get; set; }
        public int Empnum { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime? Duedt { get; set; }
        public bool? Completed { get; set; }
        public DateTime? Completedt { get; set; }
        public string Comment { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public string Attachment3 { get; set; }
        public float? Rqdhr { get; set; }
        public float? Achievedhr { get; set; }
        public DateTime? Autoschednexttran { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
