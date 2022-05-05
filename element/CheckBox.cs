using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Base;

namespace element
{
     class CheckBox :Class1
    {
        public  void check_box()
        {
          
             chrome("https://demoqa.com/checkbox");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           

            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[2].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[3].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[6].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[7].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[8].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[10].Click();
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[11].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[12].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[13].Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[15].Click();
            time(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[16].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,-200)");
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
            time(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
            time(2000);
           quit();

             
        }

    }
}
