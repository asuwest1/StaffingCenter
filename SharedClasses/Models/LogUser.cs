using System;
using System.Collections.Generic;

#nullable disable

namespace SharedClasses.Models
{
    public partial class LogUser
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public bool IsActual { get; set; }
    }
}
