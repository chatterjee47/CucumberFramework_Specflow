using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class ActionMoveClick
    {
        public IWebDriver driver;

        public ActionMoveClick(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement ButtonClicks => driver.FindElement(By.XPath("//h1[contains(text(),'BUTTON CLICKS')]"));
        public IWebElement ClickMeOne => driver.FindElement(By.XPath("//span[@id='button3']"));
        public IWebElement CloseButton => driver.FindElement(By.XPath("//body/div[1]/div[6]/div[1]/div[1]/div[3]/button[1]"));

        public void Buttonbtn()
        {
            ButtonClicks.Click();
        }

        public void ClickMeOn()
        {
            ClickMeOne.Click();
        }

        public void CloseButn()
        {
            CloseButton.Click();
        }

    }
}
