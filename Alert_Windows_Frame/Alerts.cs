using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alert_Windows_Frame
{
    internal class Alerts
    {
        public static void alerts()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            Thread.Sleep(1000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
            Thread.Sleep(6000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().SendKeys("Racht");
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Driver.Close();
            Driver.Quit();

        }
    }
}
