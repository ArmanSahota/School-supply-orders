using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_supply_orders
{
    internal class Headphones
    {
        // fields
        // Connection (bluetooth or wired)
        // quality band ( plastic, metal, mixed)
        // quality ear cushions (soft, hard, stiff, ect)
        // cable (regular or braided)
        // quaity speakers (bass heavy, mids, highs, lows, pitch)
        // microphones (detachable, attached, pull out, ect)
        string _connection;
        string _qBand;
        string _qEarCushion;
        string _cable;
        string _qSpeakers;
        string _microphones;

        // properties
        public string Connection
        { get { return _connection; } 
         set { _connection = value; } 
        }

        public string QBand
        { get { return _qBand; } 
          set { _qBand = value; } 
        }

        public string QEarCushion
        { get { return _qEarCushion; }
          set { _qEarCushion = value; } 
        }

        public string Microphones
        { get { return _microphones; } 
          set{_microphones = value; } 
        }

        public string Cable
        { get { return _cable; } 
          set { _cable = value; } }

        public string Speakers
        { get { return _qSpeakers; }
          set { _qSpeakers = value; } 
        }
    }
}
