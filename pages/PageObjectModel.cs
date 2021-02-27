using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class PageObjectModel
    {
        public IWebDriver driver;

        public PageObjectModel(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement PAGEOBJECTMODELClicks => driver.FindElement(By.XPath("//h1[contains(text(),'PAGE OBJECT MODEL')]"));
        public IWebElement OurProducts => driver.FindElement(By.XPath("//a[contains(text(),'Our Products')]"));
        public IWebElement NewLaptops => driver.FindElement(By.XPath("//p[contains(text(),'New Laptops')]"));
        public IWebElement Proceedbtn => driver.FindElement(By.XPath("//button[contains(text(),'Proceed')]"));
        public IWebElement DesktopSystems => driver.FindElement(By.XPath("//p[contains(text(),'Desktop Systems')]"));
        public IWebElement VerifyText => driver.FindElement(By.XPath("//b[contains(text(),'NEWCUSTOMER773322')]"));
        public IWebElement Closebtn => driver.FindElement(By.XPath("//button[contains(text(),'Close')]"));

        public void PAGEOBJECTMODELClick()
        {
            PAGEOBJECTMODELClicks.Click();
        }

        public void OurProduct()
        {
            OurProducts.Click();
        }

        public void NewLaptop()
        {
            NewLaptops.Click();
        }

        public void Proceedbtns()
        {
            Proceedbtn.Click();
        }

        public void DesktopSystem()
        {
            DesktopSystems.Click();
        }

        public String VerifyTextMesg()
        {
            return VerifyText.Text;
        }

        public void Closebutton()
        {
            Closebtn.Click();
        }

    }
}
