using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Base;

namespace Interaction
{
    internal class Slectable :Class1
    {
        public  void selectable()
        {
         ;

            chrome("https://demoqa.com/selectable");
           
            //time(2000);
            Findxpath("//li[contains(text(),'Cras justo odio')]").Click();

            Findxpath("//li[contains(text(),'Dapibus ac facilisis in')]").Click();
            Findxpath("//li[contains(text(),'Morbi leo risus')]").Click();
            Findxpath("//li[contains(text(),'Porta ac consectetur ac')]").Click();




            // Grid

            Findxpath("//a[@id='demo-tab-grid']").Click();

            Findxpath("//li[contains(text(),'One')]").Click();

            Findxpath("//li[contains(text(),'Two')]").Click();

            Findxpath("//li[contains(text(),'Three')]").Click();

            Findxpath("//li[contains(text(),'Four')]").Click();

            Findxpath("//li[contains(text(),'Five')]").Click();

            Findxpath("//li[contains(text(),'Six')]").Click();




            Findxpath("//li[contains(text(),'Seven')]").Click();

            Findxpath("//li[contains(text(),'Eight')]").Click();

            Findxpath("//li[contains(text(),'Nine')]").Click();
            time(2000);


        }
    }
}
