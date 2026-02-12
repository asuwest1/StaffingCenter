using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class Customer
    {
        public Customer()
        {
            AllocationProjects = new HashSet<AllocationProject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<AllocationProject> AllocationProjects { get; set; }
    }
}
