using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Base;

namespace element
{
    internal class Link :Class1
    {

        public  void link()
        {
            chrome("https://demoqa.com/links");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Findid("simpleLink").Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            time(3000);
            quit();
            time(3000);
            Driver.SwitchTo().Window(o);
            time(2000);


            //Findid("dynamicLink")).Click();
            time(2000);
            Findid("created").Click();

            time(2000);
            Findid("no-content").Click();

            time(2000);
            Findid("moved").Click();

            time(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            time(2000);
            Findid("bad-request").Click();
            time(2000);

            Findid("forbidden").Click();
            time(2000);
            Findid("invalid-url").Click();
            time(2000);
           quit();
             

        }
    }
}
