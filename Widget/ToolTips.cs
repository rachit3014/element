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
    internal class ToolTips:Class1
    {
        public  void tooltips()
        {
          
           
            chrome("https://demoqa.com/tool-tips");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);

            Findxpath("//button[@id='toolTipButton']").Click();
            time(2000);
           quit();
             

        }
    }  }
