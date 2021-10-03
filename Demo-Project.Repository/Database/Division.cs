using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Division
    {
        public string Division1 { get; set; }
        public string Description { get; set; }
        public string Divaddr1 { get; set; }
        public string Divaddr2 { get; set; }
        public string Divcity { get; set; }
        public string Divstate { get; set; }
        public string Divzip { get; set; }
        public string Divphone { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
