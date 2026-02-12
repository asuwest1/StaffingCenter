using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class User
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string MicrosoftAccount { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
