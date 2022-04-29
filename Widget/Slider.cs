using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Widget
{
    internal class Slider
    {
        public static void slider()
        {



            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);


            Driver.Navigate().GoToUrl("https://demoqa.com/slider");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']")).Click();
            int xOffset = 40;
            int yOffset = 0;
            Actions action = new Actions(Driver);
            action.MoveByOffset(xOffset, yOffset).Build().Perform();
            Driver.Close();
            Driver.Quit();

        }
    }
}
