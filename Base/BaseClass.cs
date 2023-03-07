using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace POMTest1.Base
{
    public class BaseClass
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://getflywheel.com/wordpress-support/what-is-a-demo-site/");

        }

        [OneTimeTearDown]
        public void close(),,
        {
         driver.Quit()
        }
    }
}

