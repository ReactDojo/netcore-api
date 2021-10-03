using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tmscc
    {
        public string Chainid { get; set; }
        public string Chaindesc { get; set; }
        public string Level1Approver { get; set; }
        public string Level1Status { get; set; }
        public string Level2Approver { get; set; }
        public string Level2Status { get; set; }
        public string Level3Approver { get; set; }
        public string Level3Status { get; set; }
        public string Level4Approver { get; set; }
        public string Level4Status { get; set; }
        public string Level5Approver { get; set; }
        public string Level5Status { get; set; }
        public string Level6Approver { get; set; }
        public string Level6Status { get; set; }
        public string Level7Approver { get; set; }
        public string Level7Status { get; set; }
        public string Level8Approver { get; set; }
        public string Level8Status { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
