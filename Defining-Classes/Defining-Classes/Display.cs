using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class Display
    {
        private int numbColor { get; set; }
        private string size { get; set; }

        public Display()
        {
            
        }

        public Display(int numbColor, string size)
        {
            this.numbColor = numbColor;
            this.size = size;
        }

        public string ShowInfo()
        {
            return "\nDisplay{ Number of Color: " + this.numbColor + ", Size: " + this.size + "}";
        }
        }
}
