using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class SkillToEmployee
    {
        public int Id { get; set; }
        public int FkSkill { get; set; }
        public int FkEmployee { get; set; }

        public virtual Employee FkEmployeeNavigation { get; set; }
        public virtual Skill FkSkillNavigation { get; set; }
    }
}
