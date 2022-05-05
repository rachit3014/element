using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Base;

namespace Widget
{
    internal class Slider:Class1
    {
        public  void slider()
        {



          


            chrome("https://demoqa.com/slider");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           
            time(2000);
            Findxpath("//input[@class='range-slider range-slider--primary']").Click();
            int xOffset = 40;
            int yOffset = 0;
            Actions action = new Actions(Driver);
            action.MoveByOffset(xOffset, yOffset).Build().Perform();
           quit();
             

        }
    }
}
