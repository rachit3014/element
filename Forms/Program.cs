using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forms();
        }
        private static void Forms()
        {

            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            practice(Driver);
            

        }

         private static void practice(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.Id("firstName")).SendKeys("rachit");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userEmail")).SendKeys("rachitkumar3014@gmail.com");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userNumber")).SendKeys("8797982028");
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));

            CalInputBox.Click();

            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']")))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBox.SendKeys("01 Jan 2000");

            Thread.Sleep(3000);



            //Driver.FindElement(By.Id("subjectsContainer")).SendKeys("Computer");
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("uploadPicture")).SendKeys(@"E:\sampleFile (1).jpg");

            Driver.Close();
            Driver.Quit();
        }


    }
}

