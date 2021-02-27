using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class AjaxLoader
    {
        public IWebDriver driver;

        public AjaxLoader(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AjaxLoaderlink => driver.FindElement(By.XPath("//h1[contains(text(),'AJAX LOADER')]"));
        public IWebElement ClickMebtn => driver.FindElement(By.XPath("//p[contains(text(),'CLICK ME!')]"));
        public IWebElement VerifyTextOne => driver.FindElement(By.XPath("//h4[contains(text(),'Well Done For Waiting....!!!')]"));
		public IWebElement VerifyTextTwo => driver.FindElement(By.XPath("//p[contains(text(),'The waiting game can be a tricky one; this exercis')]"));
		public IWebElement Closebtn => driver.FindElement(By.XPath("//button[contains(text(),'Close')]"));

		public void AjaxLoadlink()
		{
			AjaxLoaderlink.Click();
		}

		public void ClickMebt()
		{
			ClickMebtn.Click();
		}

		public String VerifyTxtOne()
		{
			return VerifyTextOne.Text;
		}

		public String VerifyTxtTwo()
		{
			return VerifyTextTwo.Text;
		}

		public void Closebt()
		{
			Closebtn.Click();
		}
	}


}

