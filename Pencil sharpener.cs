using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_supply_orders
{
    internal class Pencil_sharpener
    {
        // fields
        // sharpener type (automatic or hand shaprener)
        // color of the sharpener
        // size 
        // angle (angle of sharpener for finner or duller tips)
        bool _SharpenerType;
        string _color;
        int _size;
        int _sharpeningAngle;

        // properties
        public bool SharpenerType
        {
            get { return _SharpenerType; }
            set { _SharpenerType = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int SharpeningAngle
        {
            get { return _sharpeningAngle; }
            set { _sharpeningAngle = value; }
        }
    }
}
