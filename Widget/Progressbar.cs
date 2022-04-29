using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Widget
{
    internal class Progressbar
    {

        public  static void progress()
        {

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(10000);
            //js.ExecuteScript("window scrollBy(0,200)");

            Driver.FindElement(By.XPath("//button[@id='resetButton']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(4000);
            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();


        }
    }
}
