using CucumberFramework.pages;
using CucumberSpecflowProject.pages;
using CucumberSpecflowProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CucumberFramework.stepdefinations
{
    [Binding]
    public class ActionMoveClickTest
    {

        IWebDriver driver;
        ActionMoveClick lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"User Clicks on Button page")]
        public void GivenUserClicksOnButtonPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

            lp = new ActionMoveClick(driver);
            lp.Buttonbtn();
            ut.Wait(5000);
        }
        
        [When(@"I click Action Move & Click (.*)")]
        public void WhenIClickActionMoveClick(string p0)
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
            lp.ClickMeOn();
            ut.Wait(5000);
        }
        
        [When(@"Click on close button")]
        public void WhenClickOnCloseButton()
        {
            lp.CloseButn();
            ut.Wait(5000);
            driver.Close();
        }
        
        [Then(@"the modal should be closed")]
        public void ThenTheModalShouldBeClosed()
        {
            driver.Quit();
            ut.Wait(5000);
        }
    }
}
