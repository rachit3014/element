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
            Textbox.textBox();
            CheckBox.check_box();
            RadioButton.radio_button();
            WebTable.webtable();
            Button.button();
            Link.link();
            //Upload_andDownload.upload_and_download();  
        }

     
     }
      
 }
       
      
      

    

