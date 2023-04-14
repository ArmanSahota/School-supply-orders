using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_supply_orders
{
    internal class Post_it_notes
    {
        // fields
        // color
        // width (size ofhow wide it is
        // height (the size of how long it is)
        // amount (number of post its)
        string _color;
        int _width;
        int _height;
        int _amount;

        // properties
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
