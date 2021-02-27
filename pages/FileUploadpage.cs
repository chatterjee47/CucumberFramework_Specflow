using OpenQA.Selenium;
using System;

namespace CucumberFramework.pages
{
    class FileUploadpage
    {
        public IWebDriver driver;

        public FileUploadpage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FileUploadlink => driver.FindElement(By.XPath("//h1[contains(text(),'FILE UPLOAD')]"));
        public IWebElement ChooseFile => driver.FindElement(By.XPath("//input[@id='myFile']"));
        public IWebElement submitbutton => driver.FindElement(By.XPath("//input[@id='submit-button']"));

        public void FileUploadlnk()
        {
            FileUploadlink.Click();
        }

        public void ChoseFile(String value)
        {
            ChooseFile.SendKeys(value);
        }

        public void submitbttn()
        {
            submitbutton.Click();
        }
    }
}
