using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CucumberFramework.pages
{
    class SelectNMDatePage
    {
        public IWebDriver driver;

        public SelectNMDatePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement DATEPICKERlink => driver.FindElement(By.XPath("//h1[contains(text(),'DATEPICKER')]"));
        public IWebElement calendertab => driver.FindElement(By.XPath("//body/div[1]/div[2]/div[1]/div[1]/span[1]/i[1]"));
        public IWebElement datepickerswitch_One => driver.FindElement(By.XPath("//table[@class=' table-condensed']/thead/tr/th[@class='datepicker-switch']"));
        public IWebElement datepickerswitch_Two => driver.FindElement(By.XPath("//table[@class='table-condensed']/thead/tr/th[contains(@class,'datepicker-switch')]"));
        public IList<IWebElement> yearselection => driver.FindElements(By.XPath("//table[@class='table-condensed']/tbody/tr/td/span[contains(@class,'year')]"));
        public IList<IWebElement> monthselection => driver.FindElements(By.XPath("//table[@class='table-condensed']/tbody/tr/td/span[contains(@class,'month')]"));
        public IList<IWebElement> dateselection => driver.FindElements(By.XPath("//table[@class=' table-condensed']/tbody/tr/td[contains(@class,'day')]"));
        public IWebElement datedisplay => driver.FindElement(By.XPath("//div[@id='datepicker']/input"));

		public void DATEPICKERlnk()
		{
			DATEPICKERlink.Click();
		}

		public void calendertb()
		{
			calendertab.Click();
		}

		public void datepickerswitchOne()
		{
			datepickerswitch_One.Click(); ;
		}

		public void datepickerswitchTwo()
		{
			datepickerswitch_Two.Click(); ;
		}

		public IList<IWebElement> yearelection()
		{
			return (IList<IWebElement>)yearselection;
		}

		public IList<IWebElement> dateslection()
		{
			return (IList<IWebElement>)dateselection;
		}

		public IList<IWebElement> monthslection()
		{
			return (IList<IWebElement>) monthselection;
		}

		public String datedsplay()
		{
			return datedisplay.GetAttribute("value");
		}
	}
}
