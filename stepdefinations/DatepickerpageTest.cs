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
    public class DatepickerpageTest
    {
        IWebDriver driver;
        Datepickerpage jsc;
        Util ut;
        String today;

        public readonly String baseUrl = "http://webdriveruniversity.com/index.html";
       
        [Given(@"I go to Datepicker page")]
        public void GivenIGoToDatepickerPage()
        {
            driver = new ChromeDriver
            {
                Url = baseUrl
            };
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);
            jsc = new Datepickerpage(driver);
            jsc.datepickerlnk();

            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
        }
        
        [When(@"I click on tomorrows date")]
        public void WhenIClickOnTomorrowsDate()
        {
            jsc.calenderlnk();
            ut.Wait(5000);
        }
        
        [Then(@"Tommorows date should be selected")]
        public void ThenTommorowsDateShouldBeSelected()
        {
            today = ut.getCurrentDay();
            ut.Wait(5000);
            ut.tomorrowdatepicker(today);
            ut.Wait(5000);
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
