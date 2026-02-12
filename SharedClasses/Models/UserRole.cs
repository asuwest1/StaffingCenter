using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int FkUser { get; set; }
        public int FkRole { get; set; }

        public virtual Role FkRoleNavigation { get; set; }
        public virtual User FkUserNavigation { get; set; }
    }
}
