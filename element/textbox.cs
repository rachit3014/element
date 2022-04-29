using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace element
{
     class Textbox
    {
        public static void textBox()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            Driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            string name = "Rachit Kumar";
            string email = "rachitkumar3014@gmail.com";
            string Caddress = "koderma";
            string Paddress = "patna";

            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userName")).SendKeys(name);
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("currentAddress")).SendKeys(Caddress);
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("permanentAddress")).SendKeys(Paddress);

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("submit")).Click();
            Task.Delay(2000).Wait();

            Console.WriteLine("test case ended");


            Driver.Close();
            Driver.Quit();

        }
    }
}
