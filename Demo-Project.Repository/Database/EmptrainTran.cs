using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class EmptrainTran
    {
        public int EmptrainTransid { get; set; }
        public int Empnum { get; set; }
        public int? Groupid { get; set; }
        public int InstrEmpnum { get; set; }
        public DateTime? Trainingdt { get; set; }
        public float? Hrs { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Trainingcode { get; set; }
        public string Units { get; set; }
        public string Inservicecd { get; set; }
        public string Bus { get; set; }
        public string Tcc { get; set; }
        public string Btwcd { get; set; }
        public string Brakecd { get; set; }
        public string Equipcd { get; set; }
        public bool? Proficient { get; set; }
        public string Reason { get; set; }
        public string Comment { get; set; }
        public DateTime? Hrsapplieddt { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
