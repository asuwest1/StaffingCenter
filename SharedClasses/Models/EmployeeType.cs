using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Fte { get; set; }
        public double Gt { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
