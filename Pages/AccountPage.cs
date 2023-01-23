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
        By ClkVerifyAcct = By.XPath("//*[@id=\"alert\"]/div[2]/a");
        By ClkCountryCode = By.ClassName("vue-select");
        By SelectCCode = By.XPath("//span[normalize-space()='+376 - Andorra']");
        By InputPcode = By.XPath("//input[@name='phone']");
        By ClkSendCodeBtn = By.CssSelector("button[type='submit']");


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
        public void ClkVerAccount()
        {
            driver.FindElement(ClkVerifyAcct).Click();

        }
        public void ClkCountCode()
        {
            driver.FindElement(ClkCountryCode).Click();

        }
        public void ClkSelectCCode()
        {
            driver.FindElement(SelectCCode).Click();

        }
        public void InputPcodenum()
        {
            driver.FindElement(InputPcode).SendKeys("123456");

        }
         public void ClkSendCodeButton()
        {
            driver.FindElement(ClkSendCodeBtn).Click();

        }
    }
}
