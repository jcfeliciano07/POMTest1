using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTest1.Pages
{
    internal class SecurityPage
    {
        IWebDriver driver;

        By ClkSecurity = By.LinkText("Security");
        By ClkChangePass = By.CssSelector(".button.--secondary.--ml-10");
        By EnterCurrentPass = By.XPath("//input[@id='change_password_form_current_password']");
        By EnterNewPass = By.Id("change_password_form_new_password");
        By EnterConPass = By.CssSelector("#change_password_form_new_password_confirmation");
        By ClkSavePass = By.Name("commit");
        By ClkCancelbtn = By.XPath("//a[@class='button --link --prepend']");

        public SecurityPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void HoverSecurityOption() //Mouse Hover function
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.TagName("img"))).Click().Build().Perform();

          
        }

        public void ClkSecureOp()
        {
            driver.FindElement(ClkSecurity).Click();
        }
        public void ClkChangePasswrd()
        {
            driver.FindElement(ClkChangePass).Click();
        }
        public void EnterCurrentPasswrd()
        {
            driver.FindElement(EnterCurrentPass).SendKeys("Current Password");
        }
        public void EnterNewPasswrd()
        {
            driver.FindElement(EnterNewPass).SendKeys("Test Password");
        }
        public void EnterConPasswrd()
        {
            driver.FindElement(EnterConPass).SendKeys("Test Password");
        }
        public void ClkSavePasswrd()
        {
            driver.FindElement(ClkSavePass).Click();
        }
        public void ClkCancelButton()
        {
            driver.FindElement(ClkCancelbtn).Click();
        }
    }
}


