using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class WorkCenterAllocation
    {
        public record Wc(int Id, string Name);
        public record ProjectWc(int Id, string Name);
        public Wc WorkCenter { get; set; }
        public ProjectWc Project { get; set; }
        public int IdEmployee { get; set; }
        public double TrueValue { get; set; }
        public List<AllocationValue> allocations { get; set; }
    }
}
