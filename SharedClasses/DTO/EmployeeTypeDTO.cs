using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class EmployeeTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fte { get; set; }
        public double Gt { get; set; }
        public decimal FTE
        {
            get { return Convert.ToDecimal(Fte); }
            set { Fte = (double)value; }
        }
        public decimal GT
        {
            get { return Convert.ToDecimal(Gt); }
            set { Gt = (double)value; }
        }
        public bool Enable { get; set; }

        public virtual ICollection<EmployeeDTO> Employees { get; set; }
    }
}
