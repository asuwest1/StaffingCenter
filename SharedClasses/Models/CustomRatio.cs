using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class CustomRatio
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ft { get; set; }
        public double Gt { get; set; }
        public int FkEmployee { get; set; }

        public virtual Employee FkEmployeeNavigation { get; set; }
    }
}
