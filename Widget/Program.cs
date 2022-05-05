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

            Accordian acordian = new Accordian();
            acordian.accordian();
            DatePicker datePicker = new DatePicker();
            datePicker.timepicker();
            Slider slidr = new Slider();
            slidr.slider();
            Progressbar progressbar = new Progressbar();
            progressbar.progress();
            Tab tab = new Tab();
            tab.tabs();
            ToolTips toolTip = new ToolTips();
            toolTip.tooltips();

            Menu meu = new Menu();
            meu.menu();

            //Accordian.accordian();
            //DatePicker.datepicker();
            //DatePicker.timepicker();
            //Slider.slider();
            //Progressbar.progress();

            //Tab.tabs();
            //ToolTips.tooltips();
            //Menu.menu();

        }
    }
}
