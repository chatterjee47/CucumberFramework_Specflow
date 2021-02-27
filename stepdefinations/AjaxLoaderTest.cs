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
    public class AjaxLoaderTest
    {
        IWebDriver driver;
        AjaxLoader jsc;
        static String ExpectedMessage;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to Ajax-Loader page")]
        public void GivenIGoToAjax_LoaderPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

            jsc = new AjaxLoader(driver);
            jsc.AjaxLoadlink();
            ut.Wait(5000);

        }
        
        [Given(@"I click Click Me")]
        public void GivenIClickClickMe()
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
            jsc.ClickMebt();
            ut.Wait(5000);

        }
        
        [Given(@"I verify the following text in the modal Well Done For Waiting")]
        public void GivenIVerifyTheFollowingTextInTheModalWellDoneForWaiting()
        {

            ut.Wait(5000);
            ExpectedMessage = jsc.VerifyTxtOne();
            Console.WriteLine("Expected Message : " + ExpectedMessage);
            Assert.AreEqual("Well Done For Waiting....!!!", ExpectedMessage);

        }
        
        [Given(@"I verify the following text in the modal The waiting game can be a tricky one; this exercise will hopefully improve your understandings of the various types of waits")]
        public void GivenIVerifyTheFollowingTextInTheModalTheWaitingGameCanBeATrickyOneThisExerciseWillHopefullyImproveYourUnderstandingsOfTheVariousTypesOfWaits()
        {
            ut.Wait(5000);
            ExpectedMessage = jsc.VerifyTxtTwo();
            Console.WriteLine("Expected Message : " + ExpectedMessage);
            Assert.AreEqual("The waiting game can be a tricky one; this exercise will hopefully improve your understandings of the various types of waits.", ExpectedMessage);

        }
        
        [Given(@"I click close")]
        public void GivenIClickClose()
        {
            jsc.Closebt();
        }
        
        [Then(@"the modal shall close")]
        public void ThenTheModalShallClose()
        {
            ut.Wait(5000);
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
