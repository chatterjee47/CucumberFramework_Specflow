using System;
using OpenQA.Selenium;

namespace CucumberFramework.pages
{
    class AccordianTextAffects
    {
        public IWebDriver driver;

        public AccordianTextAffects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AccordianTextAffectslink => driver.FindElement(By.XPath("//h1[contains(text(),'ACCORDION & TEXT AFFECTS (APPEAR & DISAPPEAR)')]"));
        public IWebElement manualtestingbtn => driver.FindElement(By.XPath("//button[@id='manual-testing-accordion']"));
        public IWebElement VerifyManualtestingText => driver.FindElement(By.XPath("//p[contains(text(),'Manual testing has for some time been the most pop')]"));
        public IWebElement cucumberBDD => driver.FindElement(By.XPath("//button[@id='cucumber-accordion']"));

		public IWebElement VerifycucumberBDDText => driver.FindElement(By.XPath("//p[contains(text(),'Cucumber (BDD) simplifies the requirement capturin')]"));
	
		public void AccordianTextAffectlink()
		{
			AccordianTextAffectslink.Click();
		}

		public void manualtestingbtTn()
		{
			manualtestingbtn.Click();
		}

		public String VerifyManualtestingTxt()
		{
			return VerifyManualtestingText.Text;
		}

		public void CucumberBDD()
		{
			cucumberBDD.Click();
		}

		public String VerifycucumberBDDTxt()
		{
			return VerifycucumberBDDText.Text;
		}
	}
}
