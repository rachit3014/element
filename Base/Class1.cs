using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Base
{

    public class Class1
    {
        //private IWebDriver Driver ;
       public IWebDriver Driver;
        public IJavaScriptExecutor Js;
       public void chrome( string url)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }
        public void time(int t)
        {
            Thread.Sleep(t);
        }
        public IWebElement Findid(string id)
        {
            
            return Driver.FindElement(By.Id(id));
            
        }
     
        public IWebElement Findxpath(string XPath)
        {
            return Driver.FindElement(By.XPath(XPath));
        }
        public IWebElement Findxpaths(string XPaths)
        {
            return Driver.FindElements(By.XPath(XPaths))[0];

        }
        public void quit()
        {
            Driver.Close();

            Driver.Quit();


        }
    }
}
