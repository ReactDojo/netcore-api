using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Project.Domain.Entities
{
    public class UserEntity
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
