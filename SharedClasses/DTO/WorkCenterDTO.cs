using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class WorkCenterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<EmployeeDTO> Employees { get; set; }
        public virtual ICollection<ActualDTO> Actuals { get; set; }
        public virtual ICollection<DemandDTO> Demands { get; set; }
        public virtual ICollection<AllocationDTO> Allocations { get; set; }

    }
}
