using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string OrgCode { get; set; }
        public double FullTimeEquivalent { get; set; }
        [Required]
        public decimal FTE
        {
            get { return Convert.ToDecimal(FullTimeEquivalent); }
            set { FullTimeEquivalent = (double)value; }
        }
        [Required]
        public decimal GT
        {
            get { return Convert.ToDecimal(GeneralTime); }
            set { GeneralTime = (double)value; }
        }

        public decimal ETC
        {
            get { return Convert.ToDecimal(FullTimeEquivalent) - Convert.ToDecimal(GeneralTime) > 0 ? Convert.ToDecimal(FullTimeEquivalent) - Convert.ToDecimal(GeneralTime) : 0; }
            set { }
        }
        public String AllRolesString
        {
            get
            {
                var value = "";
                if (IsManager)
                    value += " MA";
                if (IsProjectEngineer)
                    value += " PE";
                if (IsTpm)
                    value += " TPM";
                return value;
            }
        }

        public double GeneralTime { get; set; }
        public string TaleoReq { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int? FkWorkCenter { get; set; }
        [Required]
        public int? FkEmployeeType { get; set; }
        public bool IsManager { get; set; }
        public bool IsEngineeringManager { get; set; }
        public bool IsProjectEngineer { get; set; }
        public bool IsPoc { get; set; }
        public bool IsPm { get; set; }
        public bool IsTpm { get; set; }
        public bool Enable { get; set; }
        public int? FkMainSkill { get; set; }
        [Required]
        public int? PersonnelNumber { get; set; }
        public virtual EmployeeTypeDTO FkEmployeeTypeNavigation { get; set; }
        public virtual WorkCenterDTO FkWorkCenterNavigation { get; set; }
        public virtual ICollection<EmployeeRolAllocationProjectDTO> EmployeeRolAllocationProjects { get; set; }
        public ICollection<SkillToEmployeeDTO> SkillToEmployees { get; set; }
        public virtual ICollection<AllocationDTO> Allocations { get; set; }

        public virtual ICollection<ActualDTO> Actuals { get; set; }
        public List<(int IdProject, int IdWorkCenter, DateTime date, double TrueETC)> DemandsTest { get; set; }
        public virtual ICollection<CustomRatioDTO> CustomRatios { get; set; }
        //public virtual SkillToEmployeeDTO FkMainSkillNavigation { get; set; }
        //public SkillToEmployeeDTO MainSkill
        //{
        //    get {
        //        if (SkillToEmployees == null)
        //            return null;
        //        else
        //            return SkillToEmployees.FirstOrDefault(x => x == FkMainSkillNavigation);
        //    }
        //    set { FkMainSkillNavigation = value; }
        //}
    }
}
