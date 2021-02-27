using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class PopupsAlertspage
    {
        public IWebDriver driver;

        public PopupsAlertspage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement PopupsAlertslink => driver.FindElement(By.XPath("//h1[contains(text(),'POPUP & ALERTS')]"));
        public IWebElement JavaScriptAlert => driver.FindElement(By.XPath("//span[@id='button1']"));
        public IWebElement ModalPopup => driver.FindElement(By.XPath("//span[@id='button2']"));
        public IWebElement ModalPopupClosebtn => driver.FindElement(By.XPath("//button[contains(text(),'Close')]"));
        public IWebElement ModalPopupMessage => driver.FindElement(By.XPath("//body/div[1]/div[6]/div[1]/div[1]/div[2]/p[1]"));

		public void PopupsAlertslnk()
		{
			PopupsAlertslink.Click();
		}

		public void JavaScriptAlrt()
		{
			JavaScriptAlert.Click();
		}

		public void ModlPopup()
		{
			ModalPopup.Click();
		}

		public void ModlPopupClosebtn()
		{
			ModalPopupClosebtn.Click();
		}

		public IWebElement ModlPopupMessage()
		{
			return ModalPopupMessage;
		}

	}
}
