using System;
using OpenQA.Selenium;

namespace CucumberFramework.pages
{
    class JavaScriptClick
    {

        public IWebDriver driver;

        public JavaScriptClick(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement ButtonClicks => driver.FindElement(By.XPath("//h1[contains(text(),'BUTTON CLICKS')]"));
        public IWebElement ClickMeOne => driver.FindElement(By.XPath("//span[@id='button2']"));
        public IWebElement CloseButton => driver.FindElement(By.XPath("//body/div[1]/div[5]/div[1]/div[1]/div[3]/button[1]"));
        public IWebElement DisplayMessage => driver.FindElement(By.XPath("//h4[contains(text(),'Well I think it is.....')]"));

		public String DisplayMesg()
		{
			return DisplayMessage.Text;
		}

		public void ButtonClick()
		{
			ButtonClicks.Click();
		}

		public void ClickMeOn()
		{
			ClickMeOne.Click();
		}

		public void CloseBtn()
		{
			CloseButton.Click();
		}
	}
}
