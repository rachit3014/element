using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interaction
{
    internal class Sortable
    {
        public static void sortable()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/sortable");

            Driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            IWebElement from = Driver.FindElement(By.XPath("//div[contains(text(),'One')]"));
            IWebElement to = Driver.FindElement(By.XPath("//div[contains(text(),'Six')]"));
            Actions act = new Actions(Driver);
            act.DragAndDrop(from, to).Build().Perform();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement ew = Driver.FindElement(By.XPath("//div[contains(text(),'Six')]"));

            IWebElement wq = Driver.FindElement(By.XPath("//div[contains(text(),'Three')]"));
            Actions action = new Actions(Driver);
            action.DragAndDrop(ew, wq).Build().Perform();
            Thread.Sleep(2000);
            Grid(Driver);
        }
        public static void Grid(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(2000);
            IWebElement gh = Driver.FindElement(By.XPath("//div[contains(text(),'Three')]"));
            IWebElement jk = Driver.FindElement(By.XPath("//div[contains(text(),'Four')]"));
            js.ExecuteScript("window.scrollBy(0,500)");
            Actions lo = new Actions(Driver);
            lo.DragAndDrop(gh, jk).Build().Perform();
            Thread.Sleep(2000);




        }

    }
}
