using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Base;

namespace Alert_Windows_Frame
{
    internal class Browser_Window :Class1
    {
        public   void browse_window()
        {
            
            chrome("https://demoqa.com/browser-windows");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            
            new_tab(Driver);
            new_window(Driver);
            new_window_messsage(Driver);

        }
        private   void new_tab(IWebDriver Driver)
        {
            Findid("tabButton").Click();
            string c = Driver.WindowHandles[1];
            string p = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(c);
            time(2000);
           quit();
            time(2000);
            Driver.SwitchTo().Window(p);
            time(2000);
        }
        private  void new_window(IWebDriver Driver)
        {
            Findid("windowButton").Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            time(3000);
           quit();
            time(3000);
            Driver.SwitchTo().Window(o);
            time(2000);

        }

        private  void new_window_messsage(IWebDriver Driver)
        {
            Findid("messageWindowButton").Click();
            string y = Driver.WindowHandles[1];
            string z = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(y);
            //Driver.Manage().Window.Maximize();
            time(3000);
           quit();
            time(3000);
            Driver.SwitchTo().Window(z);
           quit();
             
        }
    }
}
