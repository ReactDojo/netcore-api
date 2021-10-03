using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class DayTotalLive
    {
        public DateTime Date { get; set; }
        public int? TotalTrips { get; set; }
    }
}
