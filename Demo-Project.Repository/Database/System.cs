using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class System
    {
        public int Recid { get; set; }
        public string Version { get; set; }
        public DateTime? Lastbackup { get; set; }
        public DateTime? Lastrepair { get; set; }
        public DateTime? Lastcompact { get; set; }
    }
}
