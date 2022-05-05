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
    internal class Progressbar:Class1
    {

        public  void progress()
        {

           
            chrome("https://demoqa.com/progress-bar");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            Findxpath("//button[@id='startStopButton']").Click();
            time(10000);
            //js.ExecuteScript("window scrollBy(0,200)");

            Findxpath("//button[@id='resetButton']").Click();
            time(2000);
            Findxpath("//button[@id='startStopButton']").Click();
            time(4000);
            Findxpath("//button[@id='startStopButton']").Click();
            time(5000);
           quit();
             


        }
    }
}
