using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.DTO
{
    public partial class AllocationDTO
    {
        public long Id { get; set; }
        public string WorkCenter { get; set; }
        public string Project { get; set; }
        public int FkProject { get; set; }
        public int FkEmployee { get; set; }
        public double AllocationValue { get; set; }
        public double DemandValue { get; set; }
        public DateTime Date { get; set; }
        public int FkWorkCenter { get; set; }
        public virtual EmployeeDTO FkEmployeeNavigation { get; set; }
        public virtual AllocationProjectDTO FkProjectNavigation { get; set; }
        public virtual WorkCenterDTO FkWorkCenterNavigation { get; set; }
    }
}
