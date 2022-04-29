using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace element
{
    internal class Button
    {
        public static void button()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            right_click(Driver);
            double_click(Driver);
            dynamicclick(Driver);

        }
        private static void right_click(IWebDriver Driver)

        {
            Actions action = new Actions(Driver);
            IWebElement el = Driver.FindElement(By.Id("rightClickBtn"));
            action.ContextClick(el).Perform();
            Thread.Sleep(2000);

        }
        private static void double_click(IWebDriver Driver)
        {

            Actions actions = new Actions(Driver);
            IWebElement ele = Driver.FindElement(By.Id("doubleClickBtn"));
            actions.DoubleClick(ele).Perform();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();

        }
        private static void dynamicclick(IWebDriver Driver)
        {
            //button[contains(text)(),'Click Me')]


            //Actions act = new Actions(Driver);
            //Driver.FindElements(By.Id("//button[contains(text(),'Click Me')]"))[2].Click();
            //act.Click().Perform();
            //Thread.Sleep(2000);
            //Thread.Sleep(2000);
            //Driver.Close();
            //Driver.Quit();

        }




    }
}
