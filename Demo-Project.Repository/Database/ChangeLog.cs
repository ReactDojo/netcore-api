using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class ChangeLog
    {
        public string Table { get; set; }
        public string RecordId1 { get; set; }
        public string RecordId2 { get; set; }
        public DateTime? ChangeDate { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string UserId { get; set; }
        public string Field { get; set; }
        public string FieldDesc { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public bool? Deleted { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
