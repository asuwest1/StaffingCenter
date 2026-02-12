using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class Allocation
    {
        public long Id { get; set; }
        public int FkProject { get; set; }
        public int FkEmployee { get; set; }
        public double AllocationValue { get; set; }
        public DateTime Date { get; set; }
        public int FkWorkCenter { get; set; }

        public virtual Employee FkEmployeeNavigation { get; set; }
        public virtual AllocationProject FkProjectNavigation { get; set; }
        public virtual WorkCenter FkWorkCenterNavigation { get; set; }
    }
}
