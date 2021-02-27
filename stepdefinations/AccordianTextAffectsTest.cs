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
    public class AccordianTextAffectsTest
    {
        IWebDriver driver;
        AccordianTextAffects jsc;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to the ACCORDION & TEXT AFFECTS \(APPEAR & DISAPPEAR\) page")]
        public void GivenIGoToTheACCORDIONTEXTAFFECTSAPPEARDISAPPEARPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

            jsc = new AccordianTextAffects(driver);
            jsc.AccordianTextAffectlink();
            ut.Wait(5000);
        }
        
        [When(@"I click on Manual Testing")]
        public void WhenIClickOnManualTesting()
        {
           

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
            jsc.manualtestingbtTn();
            ut.Wait(5000);

        }
        
        [When(@"I verify the following  Manual Testing text display")]
        public void WhenIVerifyTheFollowingManualTestingTextDisplay()
        {
           
            ut.Wait(5000);
            String ExpectedMessage = jsc.VerifyManualtestingTxt();
            Console.WriteLine("Expected Message : " + ExpectedMessage);
            Assert.AreEqual("Manual testing has for some time been the most popular way to test code. For this method, the tester plays an important role of end user and verifies that all the features of the application work correctly. Manual testing however is on the decline. Companies and developers have realised the efficiency, accuracy and cost savings that is possible by adopting the use of automation testing.", ExpectedMessage);


        }

        [When(@"I click on Cucumber BDD")]
        public void WhenIClickOnCucumberBDD()
        {
            jsc = new AccordianTextAffects(driver);
            jsc.CucumberBDD();
            ut.Wait(5000);

        }
        
        [When(@"I verify the Cucumber BDD text display")]
        public void WhenIVerifyTheCucumberBDDTextDisplay()
        {
            ut.Wait(5000);
            String ExpectedMessage = jsc.VerifycucumberBDDTxt();
            Console.WriteLine("Expected Message : " + ExpectedMessage);
            Assert.AreEqual("Cucumber (BDD) simplifies the requirement capturing process. Requirements can be captured, broken down and simplified effortlessly; making the captured requirements readable to anyone within the organisation and in turn providing the required details and backbone to develop accurate test cases also known as ‘Feature Files’.", ExpectedMessage);
            ut.Wait(5000);
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
