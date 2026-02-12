using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class Demand
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string Code { get; set; }
        public string ActivityName { get; set; }
        public string RespEngr { get; set; }
        public int Activity { get; set; }
        public DateTime ForecastStart { get; set; }
        public DateTime ForecastFinish { get; set; }
        public DateTime Date { get; set; }
        public double Etchours { get; set; }
        public double Etcfte { get; set; }
        public int FkAllocationProject { get; set; }
        public int FkWorkCenter { get; set; }

        public virtual AllocationProject FkAllocationProjectNavigation { get; set; }
        public virtual WorkCenter FkWorkCenterNavigation { get; set; }
    }
}
