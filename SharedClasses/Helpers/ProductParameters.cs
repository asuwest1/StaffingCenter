using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.Helpers
{
    public class ProductParameters
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; }
        private string searchTerm;
        public string SearchTerm
        {
            get { return searchTerm; }
            set { searchTerm = value.ToUpper(); }
        }

        public string OrderBy { get; set; }
        public bool ascendant { get; set; }
    }
}
