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
     class Upload_andDownload :Class1
    {

        public   void upload_and_download()
        {
           
            chrome("https://demoqa.com/upload-download");
           
            time(2000);
            download(Driver);
            upload(Driver);

        }
        private   void upload(IWebDriver Driver)
        {
            Findid("uploadPicture").SendKeys(@"E:\sampleFile (1).jpg");
            time(5000);
           quit();
             
        }
        private  void download(IWebDriver Driver)
        {
            Findid("downloadButton").Click();
            time(2000);


        }
    }
}
