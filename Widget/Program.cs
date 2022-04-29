using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accordian.accordian();
            DatePicker.datepicker();
            DatePicker.timepicker();
            Slider.slider();
            Progressbar.progress();
          
            Tab.tabs();
            ToolTips.tooltips();
            Menu.menu();
        }
    }
}
