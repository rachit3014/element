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
            
            new Textbox().textBox();
           // textBox.textBox();
            CheckBox checkBox = new CheckBox();
            checkBox.check_box();
            RadioButton radioButton = new RadioButton();
            radioButton.radio_button();
            WebTable webTable = new WebTable();
            webTable.webtable();
            Button buton = new Button();
            buton.button();
            Link links = new Link();
            links.link();
            Upload_andDownload upload_AndDownload = new Upload_andDownload();
            upload_AndDownload.upload_and_download();


            //Textbox.textBox();
            //CheckBox.check_box();
            //RadioButton.radio_button();
            //WebTable.webtable();
            //Button.button();
            //Link.link();
            //Upload_andDownload.upload_and_download(); 


        }


    }
      
 }
       
      
      

    

