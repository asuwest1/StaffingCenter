using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class ManagerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPm { get; set; }
        public bool IsEm { get; set; }
        public bool IsPoc { get; set; }
    }
}
