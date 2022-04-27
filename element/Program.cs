using OpenQA.Selenium;
//using OpenQA.Selenium.IJavaScriptExecutor;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextBox();
            check_box();
            radio_button();
            webtable();
            button();
            link();

            upload_and_download();
            Forms();
            Browse_window();
            alerts();
            Modal();
            accordian();
            datepicker();
            timepicker();
            slider();
            progress();
            tabs();
            tooltips();
            menu();
            sortable();
            selectable();








        }

        private static void TextBox()
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
        private static void check_box()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            Driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[2].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[3].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[6].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[7].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[8].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[10].Click();
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[11].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[12].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[13].Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[15].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[16].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200)");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
            Thread.Sleep(2000);
            Driver.Close();

            Driver.Quit();
        }
        private static void radio_button()

        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            //IWebElement button= Driver.FindElement(By.XPath("//input[@id='yesRadio']"));
            // js.ExecuteScript("arguments[0].click()", button);

            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---yes
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click();//---impressive
            Thread.Sleep(2000);
            //Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[2].Click();//--no
            IWebElement button = Driver.FindElement(By.XPath("//label[@for='noRadio']"));
            js.ExecuteScript("arguments[0].click()", button);
            Thread.Sleep(2000);
            Driver.Close();

            Driver.Quit();

        }
        private static void webtable()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("addNewRecordButton")).Click();
            Driver.FindElement(By.Id("firstName")).SendKeys("rachit");
            Driver.FindElement(By.Id("lastName")).SendKeys("kumar");
            Driver.FindElement(By.Id("userEmail")).SendKeys("ygyg@gmail.com");
            Driver.FindElement(By.Id("age")).SendKeys("20");
            Driver.FindElement(By.Id("salary")).SendKeys("2000000011");
            Driver.FindElement(By.Id("department")).SendKeys("IT");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("submit")).Click();

            Thread.Sleep(2000);
            Driver.FindElement(By.Id("delete-record-4")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();
            
        }
        private static void button()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            right_click(Driver);
            double_click(Driver);
            dynamicclick(Driver);

        }
        private static void right_click(IWebDriver Driver)

        {
            Actions action = new Actions(Driver);
            IWebElement el = Driver.FindElement(By.Id("rightClickBtn"));
            action.ContextClick(el).Perform();
            Thread.Sleep(2000);

        }
        private static void double_click(IWebDriver Driver)
        {

            Actions actions = new Actions(Driver);
            IWebElement ele = Driver.FindElement(By.Id("doubleClickBtn"));
            actions.DoubleClick(ele).Perform();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();

        }
        private static void dynamicclick(IWebDriver Driver)
        {
            //button[contains(text)(),'Click Me')]


            //Actions act = new Actions(Driver);
            //Driver.FindElements(By.Id("//button[contains(text(),'Click Me')]"))[2].Click();
            //act.Click().Perform();
            //Thread.Sleep(2000);
            //Thread.Sleep(2000);
            //Driver.Close();
            //Driver.Quit();
            
        }
        private static void link()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/links");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("simpleLink")).Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);

           
            //Driver.FindElement(By.Id("dynamicLink")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("created")).Click();

            Thread.Sleep(2000);
            Driver.FindElement(By.Id("no-content")).Click();
            
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("moved")).Click();
         
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("invalid-url")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();

        }
        private static void broken_link()
        {
            //IWebDriver Driver = new ChromeDriver();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //Thread.Sleep(2000);

            
            //Driver.Navigate().GoToUrl("https://demoqa.com/broken");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//a[contains(text(),'Click Here for Valid Link')]")).Click();
            //Thread.Sleep(2000);
            
            //string h = Driver.WindowHandles[1];

            //string o = Driver.WindowHandles[0];
            //Driver.SwitchTo().Window(h);
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(3000);
            //Driver.Close();
            //Thread.Sleep(3000);
            //Driver.SwitchTo().Window(o);
            //Thread.Sleep(2000);
            //js.ExecuteScript("window scrrolBy(0,200)");
            //Driver.FindElement(By.XPath("//a[contains(text(),'Click Here for Broken Link')]")).Click();
           
            //string r = Driver.WindowHandles[1];

            //string s = Driver.WindowHandles[0];
            //Driver.SwitchTo().Window(r);
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(3000);
            //Driver.Close();
            //Thread.Sleep(3000);
            //Driver.SwitchTo().Window(s);
            //Thread.Sleep(2000);
            

            //Driver.Close();
            //Driver.Quit();
        }
        private static void upload_and_download()
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
        private static  void download(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(2000);


        }
        private static void upload(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("uploadPicture")).SendKeys(@"E:\sampleFile (1).jpg");
            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();
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
        private static void Browse_window()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            Driver.Manage().Window.Maximize();
            new_tab(Driver);
            new_window(Driver); 
            new_window_messsage(Driver);
            
        }
        private static void new_tab(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("tabButton")).Click();
            string c = Driver.WindowHandles[1];
            string p = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(c);
            Thread.Sleep(2000);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(p);
            Thread.Sleep(2000);
        }
        private static void new_window(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("windowButton")).Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);

        }
        private static void new_window_messsage(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("messageWindowButton")).Click();
            string y = Driver.WindowHandles[1];
            string z = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(y);
            //Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(z);
            Driver.Close();
            Driver.Quit();
        }
        private static void alerts()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            Thread.Sleep(1000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
            Thread.Sleep(6000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().SendKeys("Racht");
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();
            Driver.Close();
            Driver.Quit();  

        }
        private static void Modal()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='showSmallModal']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@class='close']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='showLargeModal']")).Click();
            Driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
            
            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();
        }
        private static void accordian()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/accordian");
            Thread.Sleep(2000);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[@id='section1Heading']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[@id='section2Heading']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[@id='section2Heading']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='section3Heading']")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();


        }
        private static void datepicker()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Driver.Manage().Window.Maximize();
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));

            CalInputBox.Click();

            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']")))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBox.SendKeys("01 Jan 2023");

            Thread.Sleep(2000);
        }
        private static void timepicker()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

           


            // Time Picker


            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Driver.Manage().Window.Maximize();
            Actions actio = new Actions(Driver);
            IWebElement CalInputBo = Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']"));

            CalInputBo.Click();

            Thread.Sleep(2000);

            actio.MoveToElement(Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']")))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBo.SendKeys("01 Jan 2023 11:15 AM");

            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();
        }
        private static void slider()
        {



            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);


            Driver.Navigate().GoToUrl("https://demoqa.com/slider");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']")).Click();
            int xOffset = 40;
            int yOffset = 0;
            Actions action = new Actions(Driver);
            action.MoveByOffset(xOffset, yOffset).Build().Perform();
            Driver.Close();
            Driver.Quit();

        }
        private static void progress()
        {

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(10000);
            //js.ExecuteScript("window scrollBy(0,200)");

            Driver.FindElement(By.XPath("//button[@id='resetButton']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(4000);
            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();


        }
        private static void tabs()
        {

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/tabs");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[@id='demo-tab-origin']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[@id='demo-tab-use']")).Click();


            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[@id='demo-tab-what']")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();  

        }
        private static void tooltips()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='toolTipButton']")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();


        }
        private static void menu()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/menu");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 1')]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 2')]")).Click();
            Thread.Sleep(5000);
            Driver.FindElements(By.XPath("//a[contains(text(),'Sub Item')]"))[0].Click();
            Thread.Sleep(5000);
            Driver.FindElements(By.XPath("//a[contains(text(),'Sub Item')]"))[1].Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//a[contains(text(),'SUB SUB LIST ')]")).Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Sub Sub Item 1')]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Sub Sub Item 2')]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 3')]")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();

        }
        private static void sortable()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/sortable");

            Driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            IWebElement from = Driver.FindElement(By.XPath("//div[contains(text(),'One')]"));
            IWebElement to = Driver.FindElement(By.XPath("//div[contains(text(),'Six')]"));
            Actions act = new Actions(Driver);
            act.DragAndDrop(from, to).Build().Perform();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement ew = Driver.FindElement(By.XPath("//div[contains(text(),'Six')]"));

            IWebElement wq = Driver.FindElement(By.XPath("//div[contains(text(),'Three')]"));
            Actions action = new Actions(Driver);
            action.DragAndDrop(ew, wq).Build().Perform();
            Thread.Sleep(2000);
            Grid(Driver);
        }
        private static void Grid(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(2000);
            IWebElement gh = Driver.FindElement(By.XPath("//div[contains(text(),'Three')]"));
            IWebElement jk = Driver.FindElement(By.XPath("//div[contains(text(),'Four')]"));
            js.ExecuteScript("window.scrollBy(0,500)");
            Actions lo=new Actions(Driver);
            lo.DragAndDrop(gh, jk).Build().Perform();
            Thread.Sleep(2000);
            



        }
        private static void selectable()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            
            Driver.Navigate().GoToUrl("https://demoqa.com/selectable");
            Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//li[contains(text(),'Cras justo odio')]")).Click();
           
            Driver.FindElement(By.XPath("//li[contains(text(),'Dapibus ac facilisis in')]")).Click();
            Driver.FindElement(By.XPath("//li[contains(text(),'Morbi leo risus')]")).Click();
            Driver.FindElement(By.XPath("//li[contains(text(),'Porta ac consectetur ac')]")).Click();
            



            // Grid

            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            
            Driver.FindElement(By.XPath("//li[contains(text(),'One')]")).Click();
           
            Driver.FindElement(By.XPath("//li[contains(text(),'Two')]")).Click();
           
            Driver.FindElement(By.XPath("//li[contains(text(),'Three')]")).Click();
          
            Driver.FindElement(By.XPath("//li[contains(text(),'Four')]")).Click();
            
            Driver.FindElement(By.XPath("//li[contains(text(),'Five')]")).Click();
            
            Driver.FindElement(By.XPath("//li[contains(text(),'Six')]")).Click();
           
    
            

            Driver.FindElement(By.XPath("//li[contains(text(),'Seven')]")).Click();
            
            Driver.FindElement(By.XPath("//li[contains(text(),'Eight')]")).Click();
           
            Driver.FindElement(By.XPath("//li[contains(text(),'Nine')]")).Click();
            Thread.Sleep(2000);
         

        }

    }
}
