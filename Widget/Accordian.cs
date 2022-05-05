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
    internal class Accordian:Class1
    {
        public   void accordian()
        {
          
       

            chrome("https://demoqa.com/accordian");
            time(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//div[@id='section1Heading']").Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            time(2000);
            Findxpath("//div[@id='section2Heading']").Click();
            time(2000);
            Findxpath("//div[@id='section2Heading']").Click();
            time(2000);

            Findxpath("//div[@id='section3Heading']").Click();
            time(2000);
           quit();
             


        }
    }
}
