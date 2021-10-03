using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Vehtype
    {
        public string Vehtype1 { get; set; }
        public string Vtypdesc { get; set; }
        public short? High { get; set; }
        public short? Medium { get; set; }
        public short? Low { get; set; }
        public short? Numhand { get; set; }
        public int? Highoverfill { get; set; }
        public int? Mediumoverfill { get; set; }
        public int? Lowoverfill { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
