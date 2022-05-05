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

namespace Forms
{
    internal class Program:Class1
    {
        

        public   void Forms()
        {

            
            chrome("https://demoqa.com/automation-practice-form");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            time(2000);
            practice(Driver);
            

        }

         private   void practice(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Findid("firstName").SendKeys("rachit");
            time(2000);
            Findid("lastName").SendKeys("Kumar");
            time(2000);
            Findid("userEmail").SendKeys("rachitkumar3014@gmail.com");
            time(2000);
            Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
            time(2000);
            Findid("userNumber").SendKeys("8797982028");
            time(2000);
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Findxpath("//input[@id='dateOfBirthInput']");

            CalInputBox.Click();

            time(2000);

            action.MoveToElement(Findxpath("//input[@id='dateOfBirthInput']"))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();
            

            CalInputBox.SendKeys("01 Jan 2000");
            CalInputBox.SendKeys(Keys.Escape);

            time(3000);



            //Findid("subjectsContainer")).SendKeys("Computer");
            js.ExecuteScript("window.scrollBy(0,500)");
            time(3000);
           IWebElement ho= Findxpath("//label[@for='hobbies-checkbox-2']");
            js.ExecuteScript("arguments[0].click()",ho);
               
            time(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            time(2000);
            Findid("uploadPicture").SendKeys(@"E:\sampleFile (1).jpg");

           quit();
             
        }



    }
    class Form
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Forms();
        }
    }
}

