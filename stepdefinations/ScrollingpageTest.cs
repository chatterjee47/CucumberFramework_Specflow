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
    public class ScrollingpageTest
    {
        IWebDriver driver;
        Scrollingpage sp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to Scrolling page")]
        public void GivenIGoToScrollingPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
        }
        
        [When(@"I scroll to the Dont forget to scroll to me area")]
        public void WhenIScrollToTheDontForgetToScrollToMeArea()
        {
            sp = new Scrollingpage(driver);
            sp.scrollingaroundlnk();
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
            ut.scrolltobottom();
            ut.Wait(5000);
        }
        
        [Then(@"I verify that this character X: is showing on the page")]
        public void ThenIVerifyThatThisCharacterXIsShowingOnThePage()
        {
            sp.ClickOnTxtX();
            ut.Wait(5000);
            String verifyX = sp.VerifyTxtX();
            Console.WriteLine("Tezt display as :" + verifyX);
            if (verifyX.Contains("X:"))
            {
                Console.WriteLine("Character X: is showing on the page");
            }
            else
            {
                Console.WriteLine("Character X: is not showing on the page");
            }

            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
