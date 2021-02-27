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
    public class JavaScriptClickTest
    {
        IWebDriver driver;
        JavaScriptClick jsc;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"User is in  Button Clicks page")]
        public void GivenUserIsInButtonClicksPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
        }
        
        [When(@"I click JavaScript Click")]
        public void WhenIClickJavaScriptClick()
        {
            jsc = new JavaScriptClick(driver);
            jsc.ButtonClick();
            ut.Wait(5000);

        }
        
        [When(@"I verify that the string is present with some message")]
        public void WhenIVerifyThatTheStringIsPresentWithSomeMessage()
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
            jsc = new JavaScriptClick(driver);
            jsc.ClickMeOn();
            ut.Wait(5000);
            String ExpectedMessage = jsc.DisplayMesg();
            Console.WriteLine("Expected Message : " + ExpectedMessage);
            Assert.AreEqual("It’s that Easy!! Well I think it is.....", ExpectedMessage);
          
        }
        
        [When(@"close the pop window")]
        public void WhenCloseThePopWindow()
        {
            jsc = new JavaScriptClick(driver);
            jsc.CloseBtn();
            ut.Wait(5000);
            driver.Close();
        }
        
        [Then(@"the modal It’s that Easy!! Well I think it is should be closed")]
        public void ThenTheModalItSThatEasyWellIThinkItIsShouldBeClosed()
        {
            Console.WriteLine("The Model window is closed");
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
