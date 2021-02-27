using OpenQA.Selenium;

namespace CucumberFramework.pages
{
    class ActionsPageScenarioOne
    {
        public IWebDriver driver;

        public ActionsPageScenarioOne(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Actionslink => driver.FindElement(By.XPath("//h1[contains(text(),'ACTIONS')]"));
        public IWebElement locatorfrom => driver.FindElement(By.Id("draggable"));

		public IWebElement locatorone => driver.FindElement(By.Id("droppable"));
		public IWebElement doubleclick => driver.FindElement(By.XPath("//div[@id='double-click']"));

		public IWebElement HoverOverMeFirst => driver.FindElement(By.XPath("//button[contains(text(),'Hover Over Me First!')]"));

		public IWebElement linkone => driver.FindElement(By.XPath("//body/div[1]/div[4]/div[1]/div[1]/div[1]/a[1]"));

		public IWebElement ClickHold => driver.FindElement(By.XPath("//div[@id='click-box']"));

		public IWebElement HoverOverMeThird => driver.FindElement(By.XPath("//button[contains(text(),'Hover Over Me Third!')]"));

		public IWebElement HoverOverMeThirdlink => driver.FindElement(By.XPath("//body/div[1]/div[4]/div[1]/div[3]/div[1]/a[1]"));


		public IWebElement HoverOverMeThirdlnk()
		{
			return HoverOverMeThirdlink;
		}


		public IWebElement HoverOverMeThrd()
		{
			return HoverOverMeThird;
		}

		public IWebElement ClickHld()
		{
			return ClickHold;
		}

		public void doubleclck()
		{
			doubleclick.Click();
		}

		public IWebElement linkOne()
		{
			return linkone;
		}

		public IWebElement HoverOvrMeFirst()
		{
			return HoverOverMeFirst;
		}

		public void ActionsLink()
		{
			Actionslink.Click();
		}

		public IWebElement locatorFrom()
		{
			return locatorfrom;
		}

		public IWebElement locatorOne()
		{
			return locatorone;
		}

	}
}
