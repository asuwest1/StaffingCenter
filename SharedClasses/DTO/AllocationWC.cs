using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class AllocationWC
    {
        //public string NameEmployee { get; set; }
        public EmployeeDTO Employee { get; set; }
        public string WorkCenter { get; set; }
        public int IdWorkCenter { get; set; }
        public List<AllocationValue> demandValues { get; set; } = new List<AllocationValue>();
        public List<AllocationValue> dates { get; set; } = new List<AllocationValue>();
        //public decimal TrueValue { get; set; }
    }
}
