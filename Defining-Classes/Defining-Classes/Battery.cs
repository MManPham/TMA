using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Battery
    {
        private string model { get; set; }
        private int hourIdle { get; set; }
        private int  hourTalk { get; set; }

        public Battery()
        {
            
        }

        public Battery(string model, int hourIdle, int hourTalk)
        {
            this.model = model;
            this.hourIdle = hourIdle;
            this.hourTalk = hourTalk;
        }

        private enum BatteryType
        {
            Li_Ion,
            NiMH,
            NiCd
        }

        public string ShowBattery()
        {
            return "\nBattery{ Model: " + this.model + ", Hour Indle: " + this.hourIdle + ", Hour Talk " + this.hourTalk + "}";
        }
        }
}
