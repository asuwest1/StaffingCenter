using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class Skill
    {
        public Skill()
        {
            SkillToEmployees = new HashSet<SkillToEmployee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<SkillToEmployee> SkillToEmployees { get; set; }
    }
}
