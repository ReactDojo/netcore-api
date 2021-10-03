using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class CustomerLocation
    {
        public string Customer { get; set; }
        public string Location { get; set; }
        public bool? Active { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
