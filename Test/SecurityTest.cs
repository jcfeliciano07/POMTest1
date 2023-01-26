using NUnit.Framework;
using OpenQA.Selenium;
using POMTest1.Base;
using POMTest1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTest1.Test
{
    internal class SecurityTest: BaseClass
    {
        [Test, Order(0)]
        public void VerifySecurityPage()
        {

            LoginPage login = new LoginPage(driver);
            login.ClkLogin();
            login.TypeUsername();
            login.TypePassword();
            login.ClickLoginButton();
            Thread.Sleep(3000);

            

            SecurityPage clkSecuri = new SecurityPage(driver);
            clkSecuri.HoverSecurityOption();
            clkSecuri.ClkSecureOp();
            clkSecuri.ClkChangePasswrd();
            clkSecuri.EnterCurrentPasswrd();
            clkSecuri.EnterNewPasswrd();
            clkSecuri.EnterConPasswrd();
            clkSecuri.ClkSavePasswrd();

            //Window Browser Zoom IN & Out
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("document.body.style.transform='scale(0.7)';");

            clkSecuri.ClkCancelButton();

            Thread.Sleep(3000);

        }
    }
}

