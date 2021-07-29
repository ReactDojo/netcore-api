using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class ProjectTask
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Task { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
