using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class FundEntity
    {
        public string Fund1 { get; set; }
        public string Funddesc { get; set; }
        public bool? Budget { get; set; }
        public decimal? BudgetAmount { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
