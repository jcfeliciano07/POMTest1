using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTest1.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        By ClickNewSite = By.XPath("//a[@data-log-event='new-site_hero']");
        By ClickOwnThisSite = By.XPath("//label[@for='owner_org']");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClkCreateNewSite()
        {
            driver.FindElement(ClickNewSite).Click();
        }
        public void ClkWhoOwnSite()
        {
            driver.FindElement(ClickOwnThisSite).Click();
        }
    }
}
