using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class Actual
    {
        public long Id { get; set; }
        public string Acct { get; set; }
        public int Activity { get; set; }
        public int SubOperation { get; set; }
        public DateTime Date { get; set; }
        public int? AbsenceType { get; set; }
        public double Number { get; set; }
        public int? FkWorkCenter { get; set; }
        public int? FkEmployee { get; set; }
        public int? FkProjectAllocation { get; set; }

        public virtual Employee FkEmployeeNavigation { get; set; }
        public virtual AllocationProject FkProjectAllocationNavigation { get; set; }
        public virtual WorkCenter FkWorkCenterNavigation { get; set; }
    }
}
