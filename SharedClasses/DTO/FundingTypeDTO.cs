using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class FundingTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<AllocationProjectDTO> AllocationProjects { get; set; }
    }
}
