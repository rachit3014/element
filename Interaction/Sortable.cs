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

namespace Interaction
{
    internal class Sortable: Class1
    {
        public  void sortable()
        {
            
            chrome("https://demoqa.com/sortable");

          
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            IWebElement from = Findxpath("//div[contains(text(),'One')]");
            IWebElement to = Findxpath("//div[contains(text(),'Six')]");
            Actions act = new Actions(Driver);
            act.DragAndDrop(from, to).Build().Perform();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement ew = Findxpath("//div[contains(text(),'Six')]");

            IWebElement wq = Findxpath("//div[contains(text(),'Three')]");
            Actions action = new Actions(Driver);
            action.DragAndDrop(ew, wq).Build().Perform();
            time(2000);
            Grid(Driver);
        }
        public   void Grid(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//a[@id='demo-tab-grid']").Click();
            time(2000);
            IWebElement gh = Findxpath("//div[contains(text(),'Three')]");
            IWebElement jk = Findxpath("//div[contains(text(),'Four')]");
            js.ExecuteScript("window.scrollBy(0,500)");
            Actions lo = new Actions(Driver);
            lo.DragAndDrop(gh, jk).Build().Perform();
            time(2000);




        }

    }
}
