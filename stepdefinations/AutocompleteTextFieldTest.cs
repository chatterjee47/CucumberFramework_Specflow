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
    public class AutocompleteTextFieldTest
    {
        IWebDriver driver;
        AutocompleteTextField lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        [Given(@"I go to Autocomplete TextField page")]
        public void GivenIGoToAutocompleteTextFieldPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

            lp = new AutocompleteTextField(driver);
            lp.AutocompleteTextFieldlnk();
            ut.Wait(5000);
        }
        
        [Given(@"I type in P on the search area")]
        public void GivenITypeInPOnTheSearchArea()
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            lp.FoodItm("P");
            ut.Wait(5000);

        }
        
        [Then(@"I verify the the following came up as selection: Pizza Pepperoni Pancakes")]
        public void ThenIVerifyTheTheFollowingCameUpAsSelectionPizzaPepperoniPancakes()
        {
            ut.Wait(5000);
            ut.verifyautoselect();
           Console.WriteLine("Closing the Child window");
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
