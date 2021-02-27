using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class Datepickerpage
    {
        public IWebDriver driver;

        public Datepickerpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement datepickerlink => driver.FindElement(By.XPath("//h1[contains(text(),'DATEPICKER')]"));

        public IWebElement calenderlink => driver.FindElement(By.XPath("//body/div[1]/div[2]/div[1]/div[1]/span[1]"));
        public void datepickerlnk()
        {
            datepickerlink.Click();
        }

        public void calenderlnk()
        {
            calenderlink.Click();
        }


    }
}
