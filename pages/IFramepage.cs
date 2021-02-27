using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CucumberFramework.pages
{
	class IFramepage
	{
		public IWebDriver driver;

		public IFramepage(IWebDriver driver)
		{
			this.driver = driver;
		}

		public IWebElement iframelink => driver.FindElement(By.XPath("//h1[contains(text(),'IFRAME')]"));
		public IWebElement frame => driver.FindElement(By.XPath("//iframe[@id='frame']"));
		public IWebElement findoutmore => driver.FindElement(By.XPath("//b[contains(text(),'Find Out More!')]"));
		public IWebElement Closefindoutmore => driver.FindElement(By.XPath("//button[contains(text(),'Close')]"));
		public IWebElement ContactUs => driver.FindElement(By.XPath("//a[contains(text(),'Contact Us')]"));
		public IWebElement FirstName => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/form[1]/input[1]"));
		public IWebElement LastName => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/form[1]/input[2]"));
		public IWebElement EmailAddress => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/form[1]/input[3]"));

		public IWebElement Comments => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/form[1]/textarea[1]"));

		public IWebElement submitbtn => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/form[1]/div[1]/input[2]"));

		public IWebElement Modal => driver.FindElement(By.XPath("//body/div[@id='nav-container']/div[@id='myModal']/div[1]/div[1]/div[1]/h4[1]"));

		public IWebElement IframeTitle => driver.FindElement(By.XPath("//a[@id='nav-title']"));

		public void FirstNme(String data)
		{
			FirstName.SendKeys(data);
		}

		public void LastNme(String data)
		{
			LastName.SendKeys(data);
		}

		public void EmailAdress(String data)
		{
			EmailAddress.SendKeys(data);
		}

		public void Comment(String data)
		{
			Comments.SendKeys(data);
		}

		public void Contact_Us()
		{
			ContactUs.Click();
		}

		public void Submitbtn()
		{
			submitbtn.Click();
		}

		public void iframelnk()
		{
			iframelink.Click();
		}

		public void Findoutmore()
		{
			findoutmore.Click();
		}

		public void Clsefindoutmore()
		{
			Closefindoutmore.Click();
		}

		public IWebElement MoveToClosefindoutmore()
		{
			return Closefindoutmore;
		}

		public IWebElement Iframe()
		{
			return frame;
		}

		public IWebElement IframeTtle()
		{
			return IframeTitle;
		}

		public IWebElement modal()
		{
			return Modal;
		}

		public void verifyError()
		{
			IList<IWebElement> str = driver.FindElements(By.TagName("body"));
			String[] allText = new String[str.Count];
			int i = 0;
			foreach (IWebElement element in str)
			{
				allText[i++] = element.Text;
			}
		}

	}
}





