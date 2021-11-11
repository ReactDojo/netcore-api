using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Project.Domain.Entities
{
    public class TripreqstatusEntity
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
