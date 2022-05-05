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
    internal class Modal : Class1
    {
        public  void mmodal()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
            time(2000);

            Driver.Manage().Window.Maximize();
            time(2000);

            Findxpath("//button[@id='showSmallModal']").Click();
            time(5000);
            Findxpath("//button[@class='close']").Click();
            time(2000);

            Findxpath("//button[@id='showLargeModal']").Click();
            time(5000);
            Findxpath("//button[@id='closeLargeModal']").Click();

            time(5000);
           quit();
             
        }
       
    }
}
