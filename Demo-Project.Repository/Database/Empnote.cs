using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Empnote
    {
        public int Empnum { get; set; }
        public int Noteid { get; set; }
        public DateTime? Notedate { get; set; }
        public DateTime? Notetime { get; set; }
        public string Notevalue { get; set; }
        public string Enteredby { get; set; }
        public DateTime? Enterdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
