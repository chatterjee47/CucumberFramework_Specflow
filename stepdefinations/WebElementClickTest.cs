using CucumberSpecflowProject.pages;
using CucumberSpecflowProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CucumberFramework.stepdefinations
{
    [Binding]
    public class WebElementClickTest
    {
        IWebDriver driver;
        ButtonClicks bnk;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I am in  Button Clicks page")]
        public void GivenIAmInButtonClicksPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
        }

        [When(@"I click WebElement click me")]
        public void WhenIClickWebElementClickMe()
        {
            bnk = new ButtonClicks(driver);
            bnk.Buttonbtn();
            ut.Wait(5000);

        }

        [When(@"press close")]
        public void WhenPressClose()
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            bnk.WebElementClick();
            ut.Wait(5000);

        }

        [Then(@"the modal Congratulations should be closed")]
        public void ThenTheModalCongratulationsShouldBeClosed()
        {
            bnk.ClickOnClosebtn();
            ut.Wait(5000);
            driver.Close();
            driver.Quit();
        }
    }
}