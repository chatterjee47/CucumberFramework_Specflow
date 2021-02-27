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
    public class ActionsPageScenarioTwoTest
    {
        IWebDriver driver;
        ActionsPageScenarioOne lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I navigate go to Actions Page")]
        public void GivenINavigateGoToActionsPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
        }
        
        [Given(@"I double click on the Double Click Me! area")]
        public void GivenIDoubleClickOnTheDoubleClickMeArea()
        {
            lp = new ActionsPageScenarioOne(driver);
            lp.ActionsLink();
            ut.Wait(5000);

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();

        }
        
        [Given(@"I hover over the Hover Over Me First!")]
        public void GivenIHoverOverTheHoverOverMeFirst()
        {
            ut.Wait(5000);
            Console.WriteLine("Mouse Over and Clicking");
        }
        
        [Given(@"I click Link one")]
        public void GivenIClickLinkOne()
        {
            ut.Wait(5000);
            ut.MouseOver(lp.HoverOvrMeFirst(), lp.linkOne());
            ut.Wait(5000);

        }
        
        [Given(@"I verify the string Well done you clicked on the link!")]
        public void GivenIVerifyTheStringWellDoneYouClickedOnTheLink()
        {
            var alert = driver.SwitchTo().Alert();
            Console.WriteLine("Alert message captured : " + alert.Text);
            Assert.AreEqual("Well done you clicked on the link!", alert.Text);
            ut.Wait(5000);
        }
        
        [Given(@"I click Ok")]
        public void GivenIClickOk()
        {
            ut.Wait(5000);
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Clicked on Ok button");
        }
        
        [Then(@"The javascript modal should get close")]
        public void ThenTheJavascriptModalShouldGetClose()
        {
            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
