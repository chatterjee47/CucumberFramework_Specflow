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
    public class ActionsPageScenarioOneTest
    {
        IWebDriver driver;
        ActionsPageScenarioOne lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to Actions Page")]
        public void GivenIGoToActionsPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
        }
        
        [Given(@"I verify that the webpage is showing the text DROP HERE!")]
        public void GivenIVerifyThatTheWebpageIsShowingTheTextDROPHERE()
        {
            lp = new ActionsPageScenarioOne(driver);
            lp.ActionsLink();
            ut.Wait(5000);

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();


        }
        
        [Given(@"If I put the square Drag me to my target to the DROP HERE! area")]
        public void GivenIfIPutTheSquareDragMeToMyTargetToTheDROPHEREArea()
        {
            ut.Wait(5000);
            ut.ActionKeyword(lp.locatorFrom(), lp.locatorOne());
            ut.Wait(5000);
        }
        
        [Then(@"I verify that the drop here area is changed from DROP HERE! to Dropped")]
        public void ThenIVerifyThatTheDropHereAreaIsChangedFromDROPHEREToDropped()
        {
            ut.Wait(5000);
            String textTo = lp.locatorOne().Text;
            if (textTo.Equals("Dropped!"))
            {
                Console.WriteLine("DRAG ME TO MY TARGET! is dropped to Drop here");
            }
            else
            {
                Console.WriteLine("DRAG ME TO MY TARGET! is not dropped to Drop here");
            }

            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
            ut.Wait(5000);
        }
    }
}
