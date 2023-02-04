using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using NUnit.Framework.Internal;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace SpecFlowProject1752.StepDefinitions
{
    [Binding]
    public class TestCetvrtiZadSDef
    {
        IWebDriver driver = new FirefoxDriver();
        [Given(@"Navigate to Saucedemo Site")]
        public void GivenNavigateToSaucedemoSite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"Enter username")]
        public void WhenEnterUsername()
        {
            SeleniumSetMethods.FindText(driver, "user-name", "standard_user", "Name", "//*[@id='user-name']");
            Thread.Sleep(1000);
        }

        [When(@"Enter password")]
        public void WhenEnterPassword()
        {
            SeleniumSetMethods.FindText(driver, "password", "secret_sauce", "Name", "//*[@id='password']");
            Thread.Sleep(1000);
        }

        [When(@"Click on Login button")]
        public void WhenClickOnLoginButton()
        {
            SeleniumSetMethods.FindButton(driver, "login-button", "Name", "//*[@id='login-button']");
            Thread.Sleep(1000);
        }

        [Then(@"Browser should open Home page")]
        public void ThenBrowserShouldOpenHomePage()
        {
            String url = driver.Url;
            if(url== "https://www.saucedemo.com/inventory.html")
            {
                Console.WriteLine("Opened home page");
            }
            else Console.WriteLine("Something went wrong");

        }

        [When(@"Click on Menu button")]
        public void WhenClickOnMenuButton()
        {
            SeleniumSetMethods.FindButton(driver, "react-burger-menu-btn", "Id", "//*[@id='react-burger-menu-btn']");
            Thread.Sleep(1000);
        }

        [When(@"Click on About button")]
        public void WhenClickOnAboutButton()
        {
            SeleniumSetMethods.FindButton(driver, "about_sidebar_link", "Id", "//*[@id='about_sidebar_link']");
            Thread.Sleep(1000);
        }

        [Then(@"Browser should open About page")]
        public void ThenBrowserShouldOpenAboutPage()
        {
            String url = driver.Url;
            if (url == "https://saucelabs.com/")
            {
                Console.WriteLine("Opened about page");
            }
            else Console.WriteLine("Something went wrong");
        }

        [Then(@"Navigate back")]
        public void ThenNavigateBack()
        {
            driver.Navigate().Back();
        }

        [Then(@"Click on Menu button")]
        public void ThenClickOnMenuButton()
        {
            SeleniumSetMethods.FindButton(driver, "react-burger-menu-btn", "Id", "//*[@id='react-burger-menu-btn']");
            Thread.Sleep(1000);
        }

        [Then(@"Click on Logout button")]
        public void ThenClickOnLogoutButton()
        {
            SeleniumSetMethods.FindButton(driver, "logout_sidebar_link", "Id", "//*[@id='logout_sidebar_link']");
            Thread.Sleep(1000);
        }

        [Then(@"Browser should close")]
        public void ThenBrowserShouldClose()
        {
            driver.Close();
        }

    }
}
