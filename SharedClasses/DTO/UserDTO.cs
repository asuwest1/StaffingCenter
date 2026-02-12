using SharedClasses.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace SharedClasses.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string MicrosoftAccount { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }
        public virtual ICollection<UserRoleDTO> UserRoles { get; set; }
        public List<string> Roles
        {
            get
            {
                return UserRoles?.Select(x => x.FkRoleNavigation?.Name).ToList();
            }
        }
    }
}
