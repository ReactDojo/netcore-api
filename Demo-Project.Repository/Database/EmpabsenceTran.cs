using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class EmpabsenceTran
    {
        public int EmpabsenceTransid { get; set; }
        public int Empnum { get; set; }
        public string Absencecd { get; set; }
        public DateTime? Absencedate { get; set; }
        public float? Hrs { get; set; }
        public string Comment { get; set; }
        public int? PayTransid { get; set; }
        public DateTime? PaytransDateentered { get; set; }
        public int? CoverageAbs { get; set; }
        public bool? Allday { get; set; }
        public bool? Imported { get; set; }
        public DateTime? Begtime { get; set; }
        public DateTime? Endtime { get; set; }
        public bool? ApplyToPayroll { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
