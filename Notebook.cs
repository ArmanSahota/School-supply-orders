using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_supply_orders
{
    internal class Notebook
    {
        // fields
        // the brand of the notebook
        // number of pages
        // paper type (college rule, loose leaf, ect)
        // cover type (spiral, bound, composition, ect) 

        string _brand;
        int _numberOfPages;
        string _paperType;
        string _coverType;

        // properties
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }

        public string PaperType
        {
            get { return _paperType; }
            set { _paperType = value; }
        }

        public string CoverType
        {
            get { return _coverType; }
            set { _coverType = value; }
        }
    }
}
