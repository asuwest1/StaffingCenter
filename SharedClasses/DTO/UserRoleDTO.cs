using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class UserRoleDTO
    {
        public int Id { get; set; }
        public int FkUser { get; set; }
        public int FkRole { get; set; }
        public virtual RoleDTO FkRoleNavigation { get; set; }
        public virtual UserDTO FkUserNavigation { get; set; }
    }
}
