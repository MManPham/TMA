using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class GSM
    {

        private string model { get;  set; }
        private string manufacturer { get; set; }
        private int price { get; set; }
        private string owner { get; set; }
        public Display display { get; set; }
        private Battery battery { get; set; }

        public GSM()
        {
        }

        public GSM(string model, string manufacturer, int price, string owner, Display display, Battery battery)
        {
            if (model == null || manufacturer == null)
            {
                Console.WriteLine("model and manufacturer are mandatory");
            }
            else
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.price = price;
                this.owner = owner;
                this.display = display;
                this.battery = battery;
            }

 
        }

        public override string ToString()
        {
            GSM gsm = new GSM();
         
            return "Model: " + this.model + "\nManufacturer: " + this.manufacturer + "\nPrice: " + this.price +
                   "\nOwner: " +  this.owner + this.display.ShowInfo() + this.battery.ShowBattery();
        }

        public static GSM  IPhone4S()
        {
            Display displayIp4s = new Display(4, "3.5 inches, 36.5 cm2 (~54.0% screen-to-body ratio)");
            Battery batteryIp4s = new Battery("Non-removable Li-Po 1432 mAh battery", 200, 14);
            GSM gsmIP4s = new GSM("Iphone", "Apple", 5000000, "no Owner",displayIp4s,batteryIp4s);
            return gsmIP4s;
        }
    }
}
