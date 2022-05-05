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
     class WebTable:Class1
    {
        public  void webtable()
        {
           
            
           chrome ("https://demoqa.com/webtables");
            time(2000);
            Findid("addNewRecordButton").Click();
            Findid("firstName").SendKeys("rachit");
            Findid("lastName").SendKeys("kumar");
            Findid("userEmail").SendKeys("ygyg@gmail.com");
            Findid("age").SendKeys("20");
            Findid("salary").SendKeys("2000000011");
            Findid("department").SendKeys("IT");
            time(2000);
            Findid("submit").Click();

            time(3000);
            Findid("delete-record-4").Click();
            time(3000);
           quit();
             

        }
    }
}
