using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Base;

namespace element
{
    internal class Button : Class1
    {
        public  void button()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            Driver.Manage().Window.Maximize();
            time(2000);
            right_click(Driver);
            double_click(Driver);
            dynamicclick(Driver);

        }
        private  void right_click(IWebDriver Driver)

        {
            Actions action = new Actions(Driver);
            IWebElement el = Findid("rightClickBtn");
            action.ContextClick(el).Perform();
            time(2000);

        }
        private  void double_click(IWebDriver Driver)
        {

            Actions actions = new Actions(Driver);
            IWebElement ele = Findid("doubleClickBtn");
            actions.DoubleClick(ele).Perform();
            time(2000);
           quit();
             

        }
        private  void dynamicclick(IWebDriver Driver)
        {
            //button[contains(text)(),'Click Me')]


            //Actions act = new Actions(Driver);
            //Driver.FindElements(By.Id("//button[contains(text(),'Click Me')]"))[2].Click();
            //act.Click().Perform();
            //time(2000);
            //time(2000);
            //Driver.Close();
            // 

        }




    }
}
