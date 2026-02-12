using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class AllocationWorkCenter
    {
        public string WorkCenter { get; set; }
        public List<AllocationValue> valueDemand { get; set; }
    }
}
