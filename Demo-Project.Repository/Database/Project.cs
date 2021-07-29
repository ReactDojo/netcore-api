using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Project
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? RateOfPay { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Avatar { get; set; }
    }
}
