using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.DTO
{
    public class Month
    {
        public Month(DateTime currentTime)
        {
            CurrentTime = currentTime;
        }

        public DateTime Date { get; set; }
        public DateTime CurrentTime { get; set; }
        public string DateString
        {
            get { return Date.ToString("MM/yyyy"); }
        }

        public bool IsActual
        {
            get
            {
                return Date.Year < CurrentTime.Year || (Date.Month < CurrentTime.Month && Date.Year == CurrentTime.Year) ? true : false;
            }
        }
        public int TotalHours { get; set; }
    }
}
