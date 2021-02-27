using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class Scrollingpage
    {
        public IWebDriver driver;

        public Scrollingpage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement scrollingaroundlink => driver.FindElement(By.XPath("//h1[contains(text(),'SCROLLING AROUND')]"));
        public IWebElement VerifyTextX => driver.FindElement(By.XPath("//div[@id='zone4']"));
        public void scrollingaroundlnk()
        {
            scrollingaroundlink.Click();
        }

        public void ClickOnTxtX()
        {
            VerifyTextX.Click();
        }

        public String VerifyTxtX()
        {
            return VerifyTextX.Text; 
        }
    }
}
