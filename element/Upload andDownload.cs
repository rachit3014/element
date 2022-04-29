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
     class Upload_andDownload
    {

        public static void upload_and_download()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/upload-download");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            download(Driver);
            upload(Driver);

        }
        private static void upload(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("uploadPicture")).SendKeys(@"E:\sampleFile (1).jpg");
            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();
        }
        private static void download(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(2000);


        }
    }
}
