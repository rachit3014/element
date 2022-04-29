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
    internal class DatePicker
    {
        public static void datepicker()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Driver.Manage().Window.Maximize();
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));

            CalInputBox.Click();

            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']")))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBox.SendKeys("01 Jan 2023");

            Thread.Sleep(2000);
        }
        public static void timepicker()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);




            // Time Picker


            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Driver.Manage().Window.Maximize();
            Actions actio = new Actions(Driver);
            IWebElement CalInputBo = Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']"));

            CalInputBo.Click();

            Thread.Sleep(2000);

            actio.MoveToElement(Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']")))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBo.SendKeys("01 Jan 2023 11:15 AM");

            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();
        }
    }
}
