using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class AutocompleteTextField
    {
        public IWebDriver driver;

        public AutocompleteTextField(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AutocompleteTextFieldlink => driver.FindElement(By.XPath("//h1[contains(text(),'AUTOCOMPLETE TEXTFIELD')]"));
        public IWebElement FoodItem => driver.FindElement(By.XPath("//input[@id='myInput']"));
        public IWebElement myInputautocompleteList => driver.FindElement(By.XPath("//div[@id='myInputautocomplete-list']/div"));

        public void AutocompleteTextFieldlnk()
        {
            AutocompleteTextFieldlink.Click();
        }

        public void FoodItm(String value)
        {
            FoodItem.SendKeys(value);
        }

        public IWebElement myInputautocompleteLst()
        {
            return myInputautocompleteList;

        }

    }
}
