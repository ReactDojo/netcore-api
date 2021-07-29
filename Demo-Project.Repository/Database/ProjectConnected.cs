using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class ProjectConnected
    {
        public Guid Id { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? TaskId { get; set; }
        public Guid? UserId { get; set; }
    }
}
