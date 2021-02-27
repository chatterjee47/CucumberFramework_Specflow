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
    public class SelectNMDateTest
    {
        IWebDriver driver;
        SelectNMDatePage snmdp;
        Util ut;
        String today;

        public readonly String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"Launch Datepicker page")]
        public void GivenLaunchDatepickerPage()
        {
            driver = new ChromeDriver
            {
                Url = baseUrl
            };
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
            snmdp = new SelectNMDatePage(driver);
            snmdp.DATEPICKERlnk();

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
        }
        
        [When(@"I click on the date second november twenty twenty")]
        public void WhenIClickOnTheDateSecondNovemberTwentyTwenty()
        {
            snmdp.calendertb();
            ut.Wait(5000);
            snmdp.datepickerswitchOne();
            ut.Wait(5000);
            snmdp.datepickerswitchTwo();
            ut.Wait(5000);
            ut.verifydata(snmdp.yearelection(), "2020");
            ut.Wait(5000);
            ut.verifydata(snmdp.monthslection(), "Nov");
            ut.Wait(5000);
            ut.verifydata(snmdp.dateslection(), "2");
            ut.Wait(5000);
        }
        
        [When(@"I click on the date fifth march twenty twentyone")]
        public void WhenIClickOnTheDateFifthMarchTwentyTwentyone()
        {
            snmdp.calendertb();
            ut.Wait(5000);
            snmdp.datepickerswitchOne();
            ut.Wait(5000);
            snmdp.datepickerswitchTwo();
            ut.Wait(5000);
            ut.verifydata(snmdp.yearelection(), "2021");
            ut.Wait(5000);
            ut.verifydata(snmdp.monthslection(), "Mar");
            ut.Wait(5000);
            ut.verifydata(snmdp.dateslection(), "5");
            ut.Wait(5000);
        }
        
        [Then(@"the date fifth march twenty twentyone should be selected")]
        public void ThenTheDateFifthMarchTwentyTwentyoneShouldBeSelected()
        {
            String datedisplay = snmdp.datedsplay();
            Console.WriteLine("date display as : " + datedisplay);
            Assert.AreEqual("03-05-2021", datedisplay);
            Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            Console.WriteLine("Closing the Parent window");
            ut.ParentWindow();
            driver.Close();
        }
    }
}
