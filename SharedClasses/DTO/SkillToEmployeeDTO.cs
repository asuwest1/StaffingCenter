using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class SkillToEmployeeDTO
    {
        public int Id { get; set; }
        public int FkSkill { get; set; }
        public int FkEmployee { get; set; }
        public virtual EmployeeDTO FkEmployeeNavigation { get; set; }
        public virtual SkillDTO FkSkillNavigation { get; set; }
    }
}
