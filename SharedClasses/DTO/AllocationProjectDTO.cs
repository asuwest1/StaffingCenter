using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses.Enums;

namespace SharedClasses.DTO
{
    public class AllocationProjectDTO
    {
        public int Id { get; set; }
        [Required]
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? Network { get; set; }
        public string ProjectDescription { get; set; }
        public string Program { get; set; }
        public int? Probability { get; set; }
        public int? ProjectType { get; set; }
        public int? ProgramType { get; set; }
        public int? FkFundingType { get; set; }
        public int? FkCustomer { get; set; }
        public bool Enable { get; set; }
        public bool Firm { get; set; }
        public int? FkManagerPm { get; set; }
        public int? FkManagerEm { get; set; }
        public int? FkManagerPoc { get; set; }
        public virtual FundingTypeDTO FkFundingTypeNavigation { get; set; }
        public virtual ICollection<EmployeeRolAllocationProjectDTO> EmployeeRolAllocationProjects { get; set; }
        public virtual ICollection<ActualDTO> Actuals { get; set; }
        public virtual ICollection<DemandDTO> Demands { get; set; }

        private int? projectEngineer;
        public int? ProjectEngineer
        {
            get { return projectEngineer; }
            set { projectEngineer = value; }
        }
        private int? engineeringManager;
        public int? EngineeringManager
        {
            get { return engineeringManager; }
            set { engineeringManager = value; }
        }
        private int? poc;
        public int? POC
        {
            get { return poc; }
            set { poc = value; }
        }
        private int? pm;
        public int? PM
        {
            get { return pm; }
            set { pm = value; }
        }
        private int? tpm;
        public int? TPM
        {
            get { return tpm; }
            set { tpm = value; }
        }
    }
}
