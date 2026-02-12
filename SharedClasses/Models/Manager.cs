using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPm { get; set; }
        public bool IsEm { get; set; }
        public bool IsPoc { get; set; }
    }
}
