using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class BigCalcalnote
    {
        public DateTime NoteDate { get; set; }
        public byte[] NoteIcon { get; set; }
        public string NoteText { get; set; }
        public string NoteLongText { get; set; }
        public short? NoteSeverity { get; set; }
        public bool? NoteSchoolClosed { get; set; }
        public string IconName { get; set; }
        public int? IconSeq { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
