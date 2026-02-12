using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class EmployeeRolAllocationProject
    {
        public int Id { get; set; }
        public int FkEmployee { get; set; }
        public int FkAllocationProject { get; set; }
        public int EmployeeRol { get; set; }

        public virtual AllocationProject FkAllocationProjectNavigation { get; set; }
        public virtual Employee FkEmployeeNavigation { get; set; }
    }
}
