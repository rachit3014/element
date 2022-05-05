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
     class Textbox:Class1
    {
        public  void textBox()
        {
            //IWebDriver Driver = new ChromeDriver();
            chrome("https://demoqa.com/text-box");

           // Driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            string name = "Rachit Kumar";
            string email = "rachitkumar3014@gmail.com";
            string Caddress = "koderma";
            string Paddress = "patna";

            time(2000);
            Findid("userName").SendKeys(name);
            time(2000);
            Findid("userEmail").SendKeys(email);
            time(2000);
            Findid("currentAddress").SendKeys(Caddress);
            time(2000);
            Findid("permanentAddress").SendKeys(Paddress);

            time(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            time(2000);

            Findid("submit").Click();
            Task.Delay(2000).Wait();

            Console.WriteLine("test case ended");


           quit();
             

        }
    }
}
