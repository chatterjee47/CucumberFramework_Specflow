using OpenQA.Selenium;

namespace CucumberSpecflowProject.pages
{
    class ButtonClicks
    {

        public IWebDriver driver;

        public ButtonClicks(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Buttonlink => driver.FindElement(By.XPath("//h1[contains(text(),'BUTTON CLICKS')]"));
        public IWebElement WebElementClickbtn => driver.FindElement(By.XPath("//span[@id='button1']"));
        public IWebElement Closebtn => driver.FindElement(By.XPath("//body/div[1]/div[4]/div[1]/div[1]/div[3]/button[1]"));

        public void Buttonbtn()
        {
            Buttonlink.Click();
        }

        public void WebElementClick()
        {
            WebElementClickbtn.Click();
        }

        public void ClickOnClosebtn()
        {
            Closebtn.Click();
        }

    }
}
