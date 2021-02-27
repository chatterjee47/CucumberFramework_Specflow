using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CucumberFramework.pages
{
    class DropdownMenuCheckboxeRadioBtns
    {
        public IWebDriver driver;

        public DropdownMenuCheckboxeRadioBtns(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement DropdownMenuCheckboxeRadioBtnsClicks => driver.FindElement(By.XPath("//h1[contains(text(),'DROPDOWN, CHECKBOXE(S) & RADIO BUTTON(S)')]"));
        public IWebElement dropdowmmenuone => driver.FindElement(By.XPath("//select[@id='dropdowm-menu-1']"));
        public IWebElement dropdowmmenutwo => driver.FindElement(By.XPath("//select[@id='dropdowm-menu-2']"));
        public IWebElement dropdowmmenuthree => driver.FindElement(By.XPath("//select[@id='dropdowm-menu-3']"));
		public IWebElement checkboxthree => driver.FindElement(By.XPath("//body/div[1]/div[3]/div[1]/div[1]/label[3]/input[1]"));
		public IWebElement checkboxfour => driver.FindElement(By.XPath("//body/div[1]/div[3]/div[1]/div[1]/label[4]/input[1]"));
		public IWebElement SelectedDisabledCabbageradiobtn => driver.FindElement(By.XPath("//body/div[1]/div[5]/div[1]/div[1]/form[1]/input[2]"));
		public IWebElement SelectedDisableddropdown => driver.FindElement(By.XPath("//select[@id='fruit-selects']"));
		public IWebElement Orangeradiobtn => driver.FindElement(By.XPath("//body/div[1]/div[4]/div[1]/div[1]/form[1]/input[4]"));


		public void DropdownMenuCheckboxeRadioBtnsClick()
		{
			DropdownMenuCheckboxeRadioBtnsClicks.Click();
		}

		public IWebElement dropdowmenuone()
		{
			return dropdowmmenuone;
		}

		public IWebElement dropdowmenutwo()
		{
			return dropdowmmenutwo;
		}

		public IWebElement dropdowmenuthree()
		{
			return dropdowmmenuthree;
		}

		public void checkbxthree()
		{
			checkboxthree.Click();
		}

		public void checkbxfour()
		{
			checkboxfour.Click();
		}

		public void SelectedDisabledCabageradiobtn()
		{
			SelectedDisabledCabbageradiobtn.Click();
		}


		public IWebElement SelectedDisabledropdown()
		{
			return SelectedDisableddropdown;
		}

		public IWebElement Orangeradiobttn()
		{
			return Orangeradiobtn;
		}

		public void Selectdropdown(IWebElement dropdownoption, String Value)
		{
			var dropdowmmenuone = new SelectElement(dropdownoption);
			dropdowmmenuone.SelectByText(Value);
		}
	}


}

