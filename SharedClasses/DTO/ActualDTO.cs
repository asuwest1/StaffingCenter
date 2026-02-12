using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class ActualDTO
    {
        public long Id { get; set; }
        public string Acct { get; set; }
        public int Network { get; set; }
        public int Activity { get; set; }
        public int SubOperation { get; set; }
        public string WorkCenter { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public int? AbsenceType { get; set; }
        public double Number { get; set; }
        public int? FkWorkCenter { get; set; }
        public int? FkEmployee { get; set; }
        public int? FkProjectAllocation { get; set; }
        public virtual EmployeeDTO FkEmployeeNavigation { get; set; }
        public virtual AllocationProjectDTO FkProjectAllocationNavigation { get; set; }
        public virtual WorkCenterDTO FkWorkCenterNavigation { get; set; }
        public int? PersonnelNumber { get; set; }
    }
}
