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
    public class PageObjectModelTest
    {

        IWebDriver driver;
        PageObjectModel jsc;
        Util ut;
        public readonly String baseUrl = "http://webdriveruniversity.com/index.html";



        [Given(@"I go to the page called Page Object Model")]
        public void GivenIGoToThePageCalledPageObjectModel()
        {
            driver = new ChromeDriver
            {
                Url = baseUrl
            };
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

        }
        
        [Given(@"I click Our products")]
        public void GivenIClickOurProducts()
        {
            jsc = new PageObjectModel(driver);
            jsc.PAGEOBJECTMODELClick();
        }
        
        [Given(@"I click New Laptops")]
        public void GivenIClickNewLaptops()
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(10000);
            jsc.OurProduct();
        }
        
        [Given(@"I verify from the modal the number of NEWCUSTOMER")]
        public void GivenIVerifyFromTheModalTheNumberOfNEWCUSTOMER()
        {
            ut.Wait(20000);
            jsc.NewLaptop();
            ut.Wait(30000);
            String ExpectedMessage = jsc.VerifyTextMesg();
            Console.WriteLine("Expected Message : " + ExpectedMessage);
            Assert.AreEqual("NEWCUSTOMER773322", ExpectedMessage);

        }
        
        [Given(@"I click proceed")]
        public void GivenIClickProceed()
        {
            ut.Wait(5000);
            jsc.Proceedbtns();
            ut.Wait(5000);

        }
        
        [Given(@"I click desktop systems")]
        public void GivenIClickDesktopSystems()
        {
            ut.Wait(5000);
            jsc.DesktopSystem();
            ut.Wait(5000);
        }
        
        [Given(@"I click Cancel")]
        public void GivenIClickCancel()
        {
            ut.Wait(5000);
            jsc.Closebutton();
            ut.Wait(5000);

        }
        
        [Then(@"the modal should be cancelled")]
        public void ThenTheModalShouldBeCancelled()
        {
            ut.Wait(5000);
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
