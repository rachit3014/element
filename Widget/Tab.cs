using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Base;

namespace Widget
{
    internal class Tab:Class1
    {
        public  void tabs()
        {

           
            chrome("https://demoqa.com/tabs");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            Findxpath("//a[@id='demo-tab-origin']").Click();
            time(2000);
            Findxpath("//a[@id='demo-tab-use']").Click();


            time(2000);
            Findxpath("//a[@id='demo-tab-what']").Click();
            time(2000);
           quit();
             

        }
    }
}
