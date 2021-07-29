using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Tasks
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public bool? Completed { get; set; }
        public string Task1 { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
