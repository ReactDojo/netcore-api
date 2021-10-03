using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class TmscuPp
    {
        public string Tmsc1 { get; set; }
        public string Perm { get; set; }
        public string Product { get; set; }
        public bool Authority { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
