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
    public class PopupsAlertspageTest
    {
        IWebDriver driver;
        PopupsAlertspage sp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to Popups & Alerts page")]
        public void GivenIGoToPopupsAlertsPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
        }
        
        [When(@"I click on click me on JavaScript Alert")]
        public void WhenIClickOnClickMeOnJavaScriptAlert()
        {
            sp = new PopupsAlertspage(driver);
            sp.PopupsAlertslnk();
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);

        }
        
        [When(@"I click Ok on the javascript modal")]
        public void WhenIClickOkOnTheJavascriptModal()
        {
            sp.JavaScriptAlrt();

            ut.Wait(5000);
            var alert = driver.SwitchTo().Alert();
            Console.WriteLine("Alert message captured : " + alert.Text);
            Assert.AreEqual("I am an alert box!", alert.Text);
            ut.Wait(5000);
            alert.Accept();
            Console.WriteLine("Clicked on Ok button");
        }
        
        [When(@"I click on click me on Modal Popup")]
        public void WhenIClickOnClickMeOnModalPopup()
        {
            ut.Wait(5000);
            sp.ModlPopup();
            ut.Wait(5000);
        }
        
        [When(@"I verify the following text from the modal We can inject and use JavaScript code if all else fails! Remember always try to use WebDriver Library method\(s\) first such as WebElement\.click\(\)\. \(The Selenium development team have spent allot of time developing WebDriver functions etc\)\.")]
        public void WhenIVerifyTheFollowingTextFromTheModalWeCanInjectAndUseJavaScriptCodeIfAllElseFailsRememberAlwaysTryToUseWebDriverLibraryMethodSFirstSuchAsWebElement_Click_TheSeleniumDevelopmentTeamHaveSpentAllotOfTimeDevelopingWebDriverFunctionsEtc_()
        {
            ut.Wait(5000);
            String ExpectedModalMessage = sp.ModlPopupMessage().Text;
            Console.WriteLine(ExpectedModalMessage);
            Assert.AreEqual("We can inject and use JavaScript code if all else fails! Remember always try to use WebDriver Library method(s) first such as WebElement.click(). (The Selenium development team have spent allot of time developing WebDriver functions etc).", ExpectedModalMessage);
            ut.Wait(5000);
        }
        
        [When(@"User click on close")]
        public void WhenUserClickOnClose()
        {
            ut.Wait(5000);
            sp.ModlPopupClosebtn();

        }
        
        [Then(@"modalwindow should be closed")]
        public void ThenModalwindowShouldBeClosed()
        {
            ut.Wait(5000);
            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
