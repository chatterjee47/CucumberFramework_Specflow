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
    public class VerifyWebsitesTest
    {
        IWebDriver driver;
        VerifyWebsitesPage snmdp;
        Util ut;
        String today;

        public readonly String baseUrlOne = "http://webdriveruniversity.com/index.html";
        public readonly String baseUrlTwo = "https://www.simonskitchens.com/";

        [Given(@"that I go to webdriveruniversity url")]
        public void GivenThatIGoToWebdriveruniversityUrl()
        {
            driver = new ChromeDriver
            {
                Url = baseUrlOne
            };
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
           

        }
        
        [Given(@"I Go to the Login Portal")]
        public void GivenIGoToTheLoginPortal()
        {
            snmdp = new VerifyWebsitesPage(driver);
            snmdp.clickOnLoginPortal();

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);

            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            ut.ParentWindow();
            ut.Wait(5000);
        }
        
        [Given(@"I Go from the login portal to another website called simonskitchens url")]
        public void GivenIGoFromTheLoginPortalToAnotherWebsiteCalledSimonskitchensUrl()
        {
            driver.Navigate().GoToUrl(baseUrlTwo);
           // driver.Url = baseUrlTwo;
            ut.Wait(5000);
        }
        
        [Given(@"I click Kitchens")]
        public void GivenIClickKitchens()
        {
            snmdp.Kitchnstab();
            ut.Wait(5000);

        }
        
        [Given(@"I select new england eight")]
        public void GivenISelectNewEnglandEight()
        {
            snmdp.EnglandEght();
            ut.Wait(5000);
        }
        
        [Given(@"I go back to the previous page and I click again Kitchens")]
        public void GivenIGoBackToThePreviousPageAndIClickAgainKitchens()
        {
            driver.Navigate().Back();
            snmdp.Kitchnstab();
            ut.Wait(5000);
        }
        
        [Given(@"I select new england nine")]
        public void GivenISelectNewEnglandNine()
        {
            snmdp.EngladNine();
            ut.Wait(5000);
        }
        
        [Then(@"New england nine kitchen page should be shown")]
        public void ThenNewEnglandNineKitchenPageShouldBeShown()
        {
            
            String currentURL = driver.Url;
            Console.WriteLine(currentURL);
            ut.Wait(5000);
            Assert.AreEqual("https://www.simonskitchens.com/kitchens/new-england-9", currentURL);
            driver.Close();
        }
    }
}
