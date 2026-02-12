using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class DemandDTO
    {
        public long Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Code { get; set; }
        public string ActivityName { get; set; }
        public string RespEngr { get; set; }
        public int Network { get; set; }
        public int Activity { get; set; }
        public DateTime ForecastStart { get; set; }
        public DateTime ForecastFinish { get; set; }
        public string WorkCenter { get; set; }
        public DateTime Date { get; set; }
        public double Etchours { get; set; }
        public double Etcfte { get; set; }
        public int FkAllocationProject { get; set; }
        public int FkWorkCenter { get; set; }

        public virtual AllocationProjectDTO FkAllocationProjectNavigation { get; set; }
        public virtual WorkCenterDTO FkWorkCenterNavigation { get; set; }
    }
}
