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
    internal class Alerts :Class1
    {
        public  void alert()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            Driver.Manage().Window.Maximize();
            time(1000);
            Findxpath("//button[@id='alertButton']").Click();
            time(1000);
            Driver.SwitchTo().Alert().Accept();
            time(2000);
            Findxpath("//button[@id='timerAlertButton']").Click();
            time(6000);
            Driver.SwitchTo().Alert().Accept();
            time(2000);
            Findxpath("//button[@id='confirmButton']").Click();
            time(2000);
            Driver.SwitchTo().Alert().Accept();
            time(2000);
            Findxpath("//button[@id='promtButton']").Click();
            time(2000);
            Driver.SwitchTo().Alert().SendKeys("Racht");
            time(2000);
            Driver.SwitchTo().Alert().Accept();
           quit();
             

        }
    }
}
