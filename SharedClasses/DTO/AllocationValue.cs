using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses.Helpers;

namespace SharedClasses.DTO
{
    public class AllocationValue
    {
        public DateTime dateA { get; set; }
        public decimal? valueA { get; set; }
        public decimal? TrueValue { get; set; }
        public bool IsActual { get; set; }
        public decimal Demand { get; set; }
        public int MonthTotalHours { get; set; }
        public decimal? ValueHours
        {
            get
            {
                if (valueA.HasValue)
                {
                    return Math.Round(MonthTotalHours * (TrueValue.Value * valueA.Value), 2);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value != null)
                {
                    valueA = Math.Round(value.Value / MonthTotalHours / TrueValue.Value,6);
                }
                else
                {
                    valueA = null;
                }
            }
        }
        public decimal? ValueEmployeeHours
        {
            get
            {
                if (valueA.HasValue)
                {
                    return Math.Round(MonthTotalHours * valueA.Value, 2);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value != null)
                {
                    valueA = Math.Round(value.Value / MonthTotalHours, 6);
                }
                else
                {
                    valueA = null;
                }
            }
        }
        public decimal? ShowValue
        {
            get
            {
                if (valueA == null)
                {
                    return null;
                }
                else
                {
                    return Math.Round(valueA.Value, 3);
                }
            }
            set
            {
                valueA = value;
            }
        }
        public double ActualValue { get; set; }
    }
}
