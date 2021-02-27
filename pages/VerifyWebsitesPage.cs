using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CucumberFramework.pages
{
    class VerifyWebsitesPage
    {
        public IWebDriver driver;

        public VerifyWebsitesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement LoginPortallink => driver.FindElement(By.XPath("//h4[contains(text(),'Login Portal')]"));
        public IWebElement Kitchenstab => driver.FindElement(By.XPath("//div[contains(text(),'Kitchens')]"));
        public IWebElement EnglandEight => driver.FindElement(By.XPath("//div[contains(text(),'Kitchens')]/parent::li/ul/li[4]/a"));
        public IWebElement EnglandNine => driver.FindElement(By.XPath("//div[contains(text(),'Kitchens')]/parent::li/ul/li[5]/a"));

		public void clickOnLoginPortal()
		{
			LoginPortallink.Click();
		}

		public void Kitchnstab()
		{
			Kitchenstab.Click();
		}

		public void EnglandEght()
		{
			EnglandEight.Click();
		}

		public void EngladNine()
		{
			EnglandNine.Click();
		}







	}
}
