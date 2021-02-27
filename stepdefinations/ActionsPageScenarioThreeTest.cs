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
    public class ActionsPageScenarioThreeTest
    {
        IWebDriver driver;
        ActionsPageScenarioOne lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I landed on Actions Page")]
        public void GivenILandedOnActionsPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
        }
        
        [Given(@"I click on Don't Release me")]
        public void GivenIClickOnDonTReleaseMe()
        {
            lp = new ActionsPageScenarioOne(driver);
            lp.ActionsLink();
            ut.Wait(5000);

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();

            ut.ClickAndHold(lp.ClickHld());
        }
        
        [Then(@"I verify the string Well done! keep holding that click now\.\.\.\.\.")]
        public void ThenIVerifyTheStringWellDoneKeepHoldingThatClickNow_()
        {
            String ExpectedMessage = lp.ClickHld().Text;
            Console.WriteLine("Message display as : " + ExpectedMessage);
            Assert.AreEqual(ExpectedMessage, "Well done! keep holding that click now.....");
        }
        
        [Then(@"I hover over the Hover Over Me Third!")]
        public void ThenIHoverOverTheHoverOverMeThird()
        {
            ut.Wait(5000);
            Console.WriteLine("Mouse Over and Clicking");

        }
        
        [Then(@"I click the second Link one")]
        public void ThenIClickTheSecondLinkOne()
        {
            ut.Wait(5000);
            ut.MouseOver(lp.HoverOverMeThrd(), lp.HoverOverMeThirdlnk());
            ut.Wait(5000);
        }
        
        [Then(@"the Javascript modal should come up")]
        public void ThenTheJavascriptModalShouldComeUp()
        {
            var alert = driver.SwitchTo().Alert();
            Console.WriteLine("Alert message captured : " + alert.Text);
            Assert.AreEqual("Well done you clicked on the link!", alert.Text);
            alert.Accept();
            Console.WriteLine("Clicked on Ok button");
            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
