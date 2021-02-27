using CucumberFramework.pages;
using CucumberSpecflowProject.pages;
using CucumberSpecflowProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CucumberFramework.stepdefinations
{
    [Binding]
    public class IFramepageTest
    {
        IWebDriver driver;
        IFramepage lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to IFrame page")]
        public void GivenIGoToIFramePage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

            lp = new IFramepage(driver);
            lp.iframelnk();
            ut.Wait(5000);

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
        }
        
        [Given(@"I click Find out more")]
        public void GivenIClickFindOutMore()
        {
            ut.Wait(5000);
            ut.switchToIframe(lp.Iframe());
            ut.Wait(5000);
            lp.Findoutmore();
            ut.Wait(5000);
            ut.scrollToView(lp.modal());
            ut.Wait(5000);
        }
        
        [Given(@"I click Close on the modal")]
        public void GivenIClickCloseOnTheModal()
        {
            lp.Clsefindoutmore();
            ut.Wait(5000);
        }
        
        [Given(@"I click Contact us")]
        public void GivenIClickContactUs()
        {
            lp.Contact_Us();
            ut.Wait(5000);
        }
        
        [Given(@"I fill in the contact us page with all the information except with an incorrect email")]
        public void GivenIFillInTheContactUsPageWithAllTheInformationExceptWithAnIncorrectEmail()
        {
            ut.Wait(5000);
            lp.FirstNme("amit");
            lp.LastNme("chatterjee");
            lp.EmailAdress("abcdamit.com");
            lp.Comment("happy");
            ut.Wait(5000);
        }
        
        [Given(@"I click submit")]
        public void GivenIClickSubmit()
        {
            lp.Submitbtn();
            ut.Wait(5000);

        }
        
        [Given(@"I verify the error message Error: Invalid email address")]
        public void GivenIVerifyTheErrorMessageErrorInvalidEmailAddress()
        {
            ut.Wait(5000);
            lp.verifyError();
        }
        
        [Given(@"on the browser I click the previous button")]
        public void GivenOnTheBrowserIClickThePreviousButton()
        {
            ut.Wait(5000);
            driver.Navigate().Back();
        }
        
        [Given(@"on the browser I click the previous button again")]
        public void GivenOnTheBrowserIClickThePreviousButtonAgain()
        {
            ut.Wait(5000);
            driver.Navigate().Back();
        }
        
        [Then(@"I should go back to the IFrame page")]
        public void ThenIShouldGoBackToTheIFramePage()
        {
            ut.Wait(5000);
            Assert.AreEqual("WebdriverUniversity.com (IFrame)", lp.IframeTtle().Text);
            ut.Wait(5000);
            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            Console.WriteLine("Closing the Parent window");
            driver.Quit();
        }
    }
}
