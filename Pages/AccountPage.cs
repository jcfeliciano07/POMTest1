using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTest1.Pages
{
    internal class AccountPage
    {
        IWebDriver driver;

        By ClkAcct = By.LinkText("Account");


        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void HoverAcctOption() //Mouse Hover function
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.TagName("img"))).Click().Build().Perform();
        }

        public void ClkAcctOp()
        {
            driver.FindElement(ClkAcct).Click();

        }
    }
}
