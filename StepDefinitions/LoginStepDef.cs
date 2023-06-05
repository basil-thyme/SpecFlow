using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDef
    { 
        private IWebDriver driver;

        public LoginStepDef(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
            /* driver = new ChromeDriver();
             driver.Manage().Window.Maximize(); */

            driver.Url = "https://www.saucedemo.com/";
            Thread.Sleep(2000);          
        }

        [When(@"I enter user name ""([^""]*)""")]
        public void WhenIEnterUserName(string p0)
        {
            driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys(p0);
            Thread.Sleep(2000);
        }

        [When(@"I enter password ""([^""]*)""")]
        public void WhenIEnterPassword(string p0)
        {
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(p0);
            Thread.Sleep(2000);

        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()

        {
            driver.FindElement(By.XPath("//input[@id='login-button']")).SendKeys(Keys.Enter);
        }

        [Then(@"I should login successfully")]
        public void ThenIShouldLoginSuccessfully()
        {
           // driver.Quit();
        }
        [When(@"I enter user name ""([^""]*)"" now")]
        public void WhenIEnterUserNameNow(string p0)
        {
            driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys(p0);
            Thread.Sleep(2000);
        }

        [Then(@"I should not be login successfully")]
        public void ThenIShouldNotBeLoginSuccessfully()
        {
            
        }


    }
}