using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Actuals = new HashSet<Actual>();
            Allocations = new HashSet<Allocation>();
            CustomRatios = new HashSet<CustomRatio>();
            EmployeeRolAllocationProjects = new HashSet<EmployeeRolAllocationProject>();
            SkillToEmployees = new HashSet<SkillToEmployee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string OrgCode { get; set; }
        public double FullTimeEquivalent { get; set; }
        public double GeneralTime { get; set; }
        public string TaleoReq { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int? FkWorkCenter { get; set; }
        public int? FkEmployeeType { get; set; }
        public bool IsManager { get; set; }
        public bool IsProjectEngineer { get; set; }
        public bool IsEngineeringManager { get; set; }
        public bool IsPoc { get; set; }
        public bool IsPm { get; set; }
        public bool IsTpm { get; set; }
        public bool Enable { get; set; }
        public int? FkMainSkill { get; set; }
        public int? PersonnelNumber { get; set; }

        public virtual EmployeeType FkEmployeeTypeNavigation { get; set; }
        public virtual WorkCenter FkWorkCenterNavigation { get; set; }
        public virtual ICollection<Actual> Actuals { get; set; }
        public virtual ICollection<Allocation> Allocations { get; set; }
        public virtual ICollection<CustomRatio> CustomRatios { get; set; }
        public virtual ICollection<EmployeeRolAllocationProject> EmployeeRolAllocationProjects { get; set; }
        public virtual ICollection<SkillToEmployee> SkillToEmployees { get; set; }
    }
}
