using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class CustomRatioDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        //public double Value { get; set; }
        public double Ft { get; set; }
        public double Gt { get; set; }
        public string DateString
        {
            get { return Date.ToString("MM/yyyy"); }
        }
        public decimal FT
        {
            get { return (decimal)Ft; }
            set { this.Ft = (double) value; }
        }
        public decimal GT
        {
            get { return (decimal)Gt; }
            set { this.Gt = (double)value; }
        }
        public decimal ETC
        {
            get { return FT - GT; }
        }

        public bool FlagModifyGT { get; set; }
        public bool FlagModifyFT { get; set; }
        public int FkEmployee { get; set; }
        public virtual EmployeeDTO FkEmployeeNavigation { get; set; }
    }
}
