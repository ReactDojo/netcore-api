using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Project.Domain.Entities
{
    public class ProjectTaskEntity
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Task { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
