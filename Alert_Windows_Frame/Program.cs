using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alert_Windows_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Browser_Window.Browse_window();
            
            Alerts.alerts();
            Modal.mmodal();
            
        }
    }
}
