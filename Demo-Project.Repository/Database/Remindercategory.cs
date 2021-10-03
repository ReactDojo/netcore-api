using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Remindercategory
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
