using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Artrantype
    {
        public string Trancode { get; set; }
        public string Trandesc { get; set; }
        public string Typecat { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
