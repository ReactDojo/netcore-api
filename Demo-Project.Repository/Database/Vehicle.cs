using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Vehicle
    {
        public string Vehicle1 { get; set; }
        public string Vehtype { get; set; }
        public bool? Alternate { get; set; }
        public DateTime? Datelstuse { get; set; }
        public short? Manyear { get; set; }
        public string Vehdesc { get; set; }
        public string Make { get; set; }
        public string Fueltype { get; set; }
        public string Vehlic { get; set; }
        public float? Miles { get; set; }
        public string Vuser1 { get; set; }
        public string Vuser2 { get; set; }
        public string Vuser3 { get; set; }
        public string Zonarid { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
