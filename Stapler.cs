using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_supply_orders
{
    internal class Stapler
    {
        //fields
        // capacity (how many staplers can it hold)
        // color (which color is the stapler)
        // autoReload (can it automatically reload the staples?)
        // size (how big are the staples?)
        int _capacity;
        string _color;
        bool _autoReload;
        int _stapleSize;

        // properties
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public bool AutoReload
        {
            get { return _autoReload; }
            set { _autoReload = value; }
        }

        public int StapleSize
        {
            get { return _stapleSize; }
            set { _stapleSize = value; }
        }
    }
}
