using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Project.Domain.Entities
{
    public class ProjectConnectedEntity
    {
        public Guid Id { get; set; }

        public Guid ProjectId { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? RateOfPay { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Avatar { get; set; }

        public List<Guid> TaskIds { get; set; }
        public List<Guid> UserIds { get; set; }
    }
}
