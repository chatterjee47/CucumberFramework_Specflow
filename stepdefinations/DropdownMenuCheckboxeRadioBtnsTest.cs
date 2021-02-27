using CucumberFramework.pages;
using CucumberSpecflowProject.pages;
using CucumberSpecflowProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CucumberFramework.stepdefinations
{
    [Binding]
    public class DropdownMenuCheckboxeRadioBtnsTest
    {
        IWebDriver driver;
        DropdownMenuCheckboxeRadioBtns lp;
        Util ut;
        String baseUrl = "http://webdriveruniversity.com/index.html";

        
        [Given(@"Land on Dropdown Menu\(s\), Checkboxe\(s\), Radio Btns page")]
        public void GivenLandOnDropdownMenuSCheckboxeSRadioBtnsPage()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            ut = new Util(driver);
            ut.Wait(5000);

            lp = new DropdownMenuCheckboxeRadioBtns(driver);
            lp.DropdownMenuCheckboxeRadioBtnsClick();
            ut.Wait(5000);

        }
        
        [Given(@"from the Dropdown Menu\(s\) I select C\#")]
        public void GivenFromTheDropdownMenuSISelectC()
        {
            ut.Wait(5000);
            ut.ParentWindowHandle();
            ut.WindowHandle();
            ut.ChildWindow();
            ut.Wait(5000);
            lp.Selectdropdown(lp.dropdowmenuone(), "C#");

        }
        
        [Given(@"from the second Dropdown Menu I select Junit")]
        public void GivenFromTheSecondDropdownMenuISelectJunit()
        {
            ut.Wait(5000);
            lp.Selectdropdown(lp.dropdowmenutwo(), "JUnit");
        }
        
        [Given(@"from the third Dropdown Menu I select Html")]
        public void GivenFromTheThirdDropdownMenuISelectHtml()
        {
            ut.Wait(5000);
            lp.Selectdropdown(lp.dropdowmenuthree(), "HTML");
        }
        
        [Given(@"again from the third Dropdown Menu I change Html to css")]
        public void GivenAgainFromTheThirdDropdownMenuIChangeHtmlToCss()
        {
            ut.Wait(5000);
            lp.Selectdropdown(lp.dropdowmenuthree(), "CSS");
        }
        
        [Given(@"from the Checkboxe\(s\) I click on option three and option four")]
        public void GivenFromTheCheckboxeSIClickOnOptionThreeAndOptionFour()
        {
            lp.checkbxthree();
            ut.Wait(5000);
            lp.checkbxfour();
            ut.Wait(5000);

        }
        
        [Given(@"from the Selected & Disabled I click Cabbage")]
        public void GivenFromTheSelectedDisabledIClickCabbage()
        {
            lp.SelectedDisabledCabageradiobtn();
            ut.Wait(5000);

        }
        
        [Given(@"from the Selected & Disabled dropdown menu I select Pear")]
        public void GivenFromTheSelectedDisabledDropdownMenuISelectPear()
        {
            lp.Selectdropdown(lp.SelectedDisabledropdown(), "Pear");
            ut.Wait(5000);
        }
        
        [Given(@"I click again the Selected & Disabled dropdown menu and I verify that Orange is disabled")]
        public void GivenIClickAgainTheSelectedDisabledDropdownMenuAndIVerifyThatOrangeIsDisabled()
        {
            if (lp.Orangeradiobttn().Enabled)
                Console.WriteLine("Button is enabled");
            else
                Console.WriteLine("Button is disabled");
                ut.Wait(5000);
        }
        
        
        [Then(@"we should be able to verify that Orange is disabled")]
        public void ThenWeShouldBeAbleToVerifyThatOrangeIsDisabled()
        {
            driver.Close();
            ut.Wait(5000);
            driver.Quit();
        }
    }
}
