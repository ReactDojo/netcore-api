using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class User
    {
        public Guid? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public string Mobile { get; set; }
        public string Home { get; set; }
        public string Company { get; set; }
        public string Notes { get; set; }
    }
}
