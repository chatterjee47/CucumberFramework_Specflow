using CucumberFramework.pages;
using CucumberSpecflowProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CucumberFramework.stepdefinations
{
    [Binding]
    public class FileUploadpageTest
    {
        IWebDriver driver;
        FileUploadpage jsc;
        Util ut;
        static String basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\source\\repos\\CucumberFramework\\data\\PNGFile.PNG";
        public readonly String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to File Upload page")]
        public void GivenIGoToFileUploadPage()
        {
            driver = new ChromeDriver
            {
                Url = baseUrl
            };
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
            jsc = new FileUploadpage(driver);
            jsc.FileUploadlnk();
        }
        
        [Given(@"I click Choose file")]
        public void GivenIClickChooseFile()
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);

        

        }
        
        [Given(@"I choose a file from the pc and upload it")]
        public void GivenIChooseAFileFromThePcAndUploadIt()
        {
            Console.WriteLine(basePath);
            ut.Wait(1000);
            jsc.ChoseFile(basePath);
            Console.WriteLine("File is Uploaded Successfully");
            ut.Wait(5000);

        }
        
        [Given(@"I click on submit button")]
        public void GivenIClickOnSubmitButton()
        {
            jsc.submitbttn();
            ut.Wait(5000);

        }
        
        [Then(@"a modal confirmation shows Your file has now been uploaded!")]
        public void ThenAModalConfirmationShowsYourFileHasNowBeenUploaded()
        {
            ut.Wait(5000);
            var alert = driver.SwitchTo().Alert();
            Console.WriteLine("Alert message captured : " + alert.Text);
            Assert.AreEqual("Your file has now been uploaded!", alert.Text);
            ut.Wait(5000);
            alert.Accept();
            Console.WriteLine("Clicked on Ok button");
            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            Console.WriteLine("Closing the Parent window");
            driver.Quit();

        }
    }
}
