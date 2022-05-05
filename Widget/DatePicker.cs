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
    internal class DatePicker:Class1
    {
        public  void datepicker()
        {
           

            chrome("https://demoqa.com/date-picker");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Findxpath("//input[@id='datePickerMonthYearInput']");

            CalInputBox.Click();

            time(2000);

            action.MoveToElement(Findxpath("//input[@id='datePickerMonthYearInput']"))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBox.SendKeys("01 Jan 2023");

            time(2000);
        }
        public  void timepicker()
        {
          




            // time Picker


            chrome("https://demoqa.com/date-picker");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Actions actio = new Actions(Driver);
            IWebElement CalInputBo = Findxpath("//input[@id='dateAndtimePickerInput']");

            CalInputBo.Click();

            time(2000);

            actio.MoveToElement(Findxpath("//input[@id='dateAndtimePickerInput']"))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBo.SendKeys("01 Jan 2023 11:15 AM");

            time(2000);
           quit();
             
        }
    }
}
