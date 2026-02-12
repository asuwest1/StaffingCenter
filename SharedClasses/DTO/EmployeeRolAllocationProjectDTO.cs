using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class EmployeeRolAllocationProjectDTO
    {
        public int Id { get; set; }
        public int FkEmployee { get; set; }
        public int FkAllocationProject { get; set; }
        public int EmployeeRol { get; set; }

        public virtual AllocationProjectDTO FkAllocationProjectNavigation { get; set; }
        public virtual EmployeeDTO FkEmployeeNavigation { get; set; }
    }
}
