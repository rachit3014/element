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



            Browser_Window browser_Window = new Browser_Window();
            browser_Window.browse_window();

            Alerts alerts = new Alerts();
            alerts.alert();

            Modal modal = new Modal();
            modal.mmodal();
            






        }
    }
}
