using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Employeeque
    {
        public string Schedule { get; set; }
        public short Empnum { get; set; }
        public bool? Skip { get; set; }
        public float? Basehrs { get; set; }
        public float? AssignhrsAct { get; set; }
        public float? AssignhrsEst { get; set; }
        public float? RefusedhrsAct { get; set; }
        public float? RefusedhrsEst { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
