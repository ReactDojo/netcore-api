using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class EventLog
    {
        public int EventId { get; set; }
        public DateTime? DateTime { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
    }
}
