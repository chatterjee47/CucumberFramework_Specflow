using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace CucumberSpecflowProject.Utilities
{
    class Util
    {
        public IWebDriver driver;
        String parentWindowHandle;
        String childId = "";

        public Util(IWebDriver driver)
        {
            this.driver = driver;
        }
		
		static String locator = "//div[@id='myInputautocomplete-list']/div";
		public void verifyautoselect()
		{
			IList<IWebElement> Autocompletelists = driver.FindElements(By.XPath(locator));
			int count = Autocompletelists.Count;
			for (int i = 0; i < count; i++)
			{
				String actualdata = Autocompletelists[i].Text;
				Console.WriteLine(actualdata);
				if (actualdata.Equals("Pizza"))
				{

					Console.WriteLine("Pizza displayed");
					Assert.AreEqual(actualdata, "Pizza");
				}
				if (actualdata.Equals("Pepperoni"))
				{

					Console.WriteLine("Pepperoni displayed");
					Assert.AreEqual(actualdata, "Pepperoni");
				}
				if (actualdata.Equals("Pancakes"))
				{

					Console.WriteLine("Pancakes displayed");
					Assert.AreEqual(actualdata, "Pancakes");
				}
			}
		}

		public void scrollToView(IWebElement locator)
		{
			((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", locator);
		}

		public void ClickAndHold(IWebElement locator)
		{
			// Actions class method to drag and drop
			Actions builder = new Actions(driver);
			// Perform click and hold
			builder.ClickAndHold(locator).Perform();
		}

		public String getCurrentDay()
		{
			string datefound = DateTime.Now.ToString("dd");
			int today = int.Parse(datefound) + 1;
		
			
			Console.WriteLine("today date is  : " + today);

			return datefound;
		}

		public void tomorrowdatepicker(String value)
		{
			
			//This are the columns of the from date picker table
			IList<IWebElement> columns = driver.FindElements(By.TagName("td"));

			//DatePicker is a table. Thus we can navigate to each cell
			//and if a cell matches with the current date then we will click it.
			foreach (IWebElement cell in columns)
			
			{
				/*foreach (var handle in lstWindow)
				//If you want to click 18th Date
				if (cell.getText().equals("18")) {
				*/
				//Select Today's Date
				if (cell.Text.Equals(value))
				{
					cell.Click();
					break;
				}
			}
		}

		public void switchToIframe(IWebElement locator)
		{
			driver.SwitchTo().Frame(locator);
		}

		public void scrolltobottom()
		{
			IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
			js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
		}
		public void MouseOver(IWebElement locatorfrom, IWebElement locatorto)
		{
			// Actions class method to drag and drop
			Actions builder = new Actions(driver);
			// Perform drag and drop
			builder.MoveToElement(locatorfrom).MoveToElement(locatorto).Click().Build().Perform();
		}

		public void ActionKeyword(IWebElement locatorfrom, IWebElement locatorone)
		{
			// Actions class method to drag and drop
			Actions builder = new Actions(driver);
			// Perform drag and drop
			builder.DragAndDrop(locatorfrom, locatorone).Perform();
		}
		public void ParentWindowHandle()
		{
			parentWindowHandle = driver.CurrentWindowHandle;
			Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

		}
		public void WindowHandle()
		{
			List<string> lstWindow = driver.WindowHandles.ToList();

			foreach (var handle in lstWindow)
			{
				Console.WriteLine("Switching to window - > " + handle);
				//Switch to the desired window first and then execute commands using driver
				driver.SwitchTo().Window(handle);
				childId = handle;
			}

		}

		public void ChildWindow()
		{
			driver.SwitchTo().Window(childId);
		}

		public void ParentWindow()
		{
			driver.SwitchTo().Window(parentWindowHandle);
		}

		public void WaitTime()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
		}

		public void Wait(int value)
		{
			System.Threading.Thread.Sleep(value);
		}

		public void verifydata(IList<IWebElement> locator, String value)
		{
			IList<IWebElement> Autocompletelists = locator;
			int count = Autocompletelists.Count;
			//	System.out.println("count of data present : " + count);
			for (int i = 0; i < count; i++)
			{
				//String actualdata = Autocompletelists.get(i).getText();
				String actualdata = Autocompletelists[i].Text;
				//	System.out.println(actualdata);
				//	pause(1000);
				if (actualdata.Equals(value))
				{
					//		pause(1000);
					Autocompletelists[i].Click();
					break;
				}
			}
		}


	}
}
