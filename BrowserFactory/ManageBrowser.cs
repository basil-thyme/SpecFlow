using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.PageObject
{
    public class ManageBrowser
    {
        public static IWebDriver driver;

        public static void SelectionofBrowser(String browser)
        {
            if (browser.Equals("chrome"))
            {
                driver = new ChromeDriver();
               
            }
            else if (browser.Equals("firefox"))
            {
                driver = new FirefoxDriver();

            }
            else
            {
                Console.WriteLine("No Browser is selected");
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


        }





    }
}
