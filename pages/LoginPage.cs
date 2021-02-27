using System;
using OpenQA.Selenium;


namespace CucumberSpecflowProject.pages
{

    public class LoginPage
    {
        public IWebDriver driver;
	
		public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement LoginPortallink => driver.FindElement(By.XPath("//h4[contains(text(),'Login Portal')]"));
        public IWebElement UsernameText => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        public IWebElement PasswordText => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//button[@id='login-button']"));

        public void ClickOnLoginPortal()
        {
            LoginPortallink.Click();
        }


        public void SetUsername(String username)
        {
            UsernameText.SendKeys(username);
        }

        public void SetPassword(String password)
        {
            PasswordText.SendKeys(password);
        }

        public void ClickOnLoginButton()
        {
            LoginButton.Click();
        }

	}

}


