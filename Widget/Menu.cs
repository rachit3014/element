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
    internal class Menu:Class1
    {
        public   void menu()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/menu");
            Driver.Manage().Window.Maximize();
            time(2000);
            Findxpath("//a[contains(text(),'Main Item 1')]").Click();
            time(2000);
            Findxpath("//a[contains(text(),'Main Item 2')]").Click();
            time(5000);
            Driver.FindElements(By.XPath("//a[contains(text(),'Sub Item')]"))[0].Click();
            time(5000);
            Driver.FindElements(By.XPath("//a[contains(text(),'Sub Item')]"))[1].Click();
            time(5000);
            Findxpath("//a[contains(text(),'SUB SUB LIST ')]").Click();
            time(5000);
            Findxpath("//a[contains(text(),'Sub Sub Item 1')]").Click();
            time(2000);
            Findxpath("//a[contains(text(),'Sub Sub Item 2')]").Click();
            time(2000);
            Findxpath("//a[contains(text(),'Main Item 3')]").Click();
            time(2000);
           quit();
             

        }
    }
}
