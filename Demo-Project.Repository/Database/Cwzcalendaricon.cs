using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Cwzcalendaricon
    {
        public string NoteIconName { get; set; }
        public string NoteIconCategory { get; set; }
        public byte[] NoteIcon { get; set; }
        public int? Iconseq { get; set; }
        public string Desc { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
