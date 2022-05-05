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
     class RadioButton:Class1
    {
        public   void radio_button()

        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            chrome("https://demoqa.com/radio-button");
            
            time(2000);
            //IWebElement button= Findxpath("//input[@id='yesRadio']"));
            // js.ExecuteScript("arguments[0].click()", button);

            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---yes
            time(2000);
            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click();//---impressive
            time(2000);
            //Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[2].Click();//--no
            IWebElement button = Findxpath("//label[@for='noRadio']");
            js.ExecuteScript("arguments[0].click()", button);
            time(2000);
           quit();

             

        }
    }
}
