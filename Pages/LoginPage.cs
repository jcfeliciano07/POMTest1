using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTest1.Pages
{
    public class LoginPage
    {
        IWebDriver driver;

        By ClickLogin = By.XPath("//a[@title='Log in']");
        By Username = By.Id("username");
        By Password = By.XPath("//input[@id='password']");
        By ClickLoginBtn = By.XPath("//button[normalize-space()='Sign in']");
 

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClkLogin()
        {
            driver.FindElement(ClickLogin).Click();
        }
        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("userselen");
        }
        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("Pass@1234567");
        }
        public void ClickLoginButton()
        {
            driver.FindElement(ClickLoginBtn).Click();

      
       
        }

    }
}

