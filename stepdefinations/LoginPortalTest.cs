using CucumberSpecflowProject.pages;
using CucumberSpecflowProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CucumberFramework.stepdefinations
{
    [Binding]
    public class LoginPortalTest
    {
        IWebDriver driver;
        LoginPage lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";


        [Given(@"I go to webdriveruniversity website")]
        public void GivenIGoToWebdriveruniversityWebsite()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

        }

        [When(@"I clicked on Login Portal link")]
        public void WhenIClickedOnLoginPortalLink()
        {
            lp = new LoginPage(driver);
            lp.ClickOnLoginPortal();
            ut.Wait(5000);
        }


        [When(@"I type Username '(.*)'")]
        public void WhenITypeUsername(string username)
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            lp.SetUsername(username);
            ut.Wait(5000);

        }

        [When(@"I type password '(.*)'")]
        public void WhenITypePassword(string password)
        {

            lp.SetPassword(password);
            ut.Wait(5000);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {

            lp.ClickOnLoginButton();
            ut.Wait(5000);
        }

        [Then(@"I can be able to log in successfully")]
        public void ThenICanBeAbleToLogInSuccessfully()
        {
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            Console.WriteLine("Loggged In successfully");
            ut.Wait(5000);
            driver.Close();

        }

        [Then(@"User close the Browser")]
        public void ThenUserCloseTheBrowser()
        {
            driver.Quit();
        }

    }
}