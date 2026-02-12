using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class WorkCenter
    {
        public WorkCenter()
        {
            Actuals = new HashSet<Actual>();
            Allocations = new HashSet<Allocation>();
            Demands = new HashSet<Demand>();
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<Actual> Actuals { get; set; }
        public virtual ICollection<Allocation> Allocations { get; set; }
        public virtual ICollection<Demand> Demands { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
