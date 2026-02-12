using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class AllocationProject
    {
        public AllocationProject()
        {
            Actuals = new HashSet<Actual>();
            Allocations = new HashSet<Allocation>();
            Demands = new HashSet<Demand>();
            EmployeeRolAllocationProjects = new HashSet<EmployeeRolAllocationProject>();
        }

        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? Network { get; set; }
        public string ProjectDescription { get; set; }
        public string Program { get; set; }
        public int? Probability { get; set; }
        public int? ProjectType { get; set; }
        public int? FkFundingType { get; set; }
        public int? FkCustomer { get; set; }
        public bool Enable { get; set; }
        public int? FkManagerPm { get; set; }
        public int? FkManagerEm { get; set; }
        public int? FkManagerPoc { get; set; }

        public virtual Customer FkCustomerNavigation { get; set; }
        public virtual FundingType FkFundingTypeNavigation { get; set; }
        public virtual ICollection<Actual> Actuals { get; set; }
        public virtual ICollection<Allocation> Allocations { get; set; }
        public virtual ICollection<Demand> Demands { get; set; }
        public virtual ICollection<EmployeeRolAllocationProject> EmployeeRolAllocationProjects { get; set; }
    }
}
