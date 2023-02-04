using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1752.StepDefinitions
{
    [Binding]
    public class MojeStepDefinitions
    {
        IWebDriver driver = new FirefoxDriver();
        [Given(@"Navigate to Execute Automation page")]
        public void GivenNavigateToExecuteAutomationPage()
        {
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
        }

        [When(@"Select title")]
        public void WhenSelectTitle()
        {
            new SelectElement(driver.FindElement(By.Id("TitleId"))).SelectByText("Mr.");
        }

        [When(@"Enter initials")]
        public void WhenEnterInitials()
        {
            driver.FindElement(By.Id("Initial")).SendKeys("T.K.");
        }

        [When(@"Enter first name")]
        public void WhenEnterFirstName()
        {
            driver.FindElement(By.Id("FirstName")).SendKeys("Toni");
        }

        [When(@"Enter middle name")]
        public void WhenEnterMiddleName()
        {
            driver.FindElement(By.Id("MiddleName")).SendKeys("Biloäta");
        }

        [When(@"Click on Save button")]
        public void WhenClickOnSaveButton()
        {
            driver.FindElement(By.Name("Save")).Click();
        }

        [Then(@"Close browser")]
        public void ThenCloseBrowser()
        {
            driver.Close();
        }
    }
}
