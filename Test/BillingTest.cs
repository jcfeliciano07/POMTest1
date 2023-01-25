using AngleSharp.Dom;
using AngleSharp.Html.InputTypes;
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
    public class BillingTest: BaseClass
    {

        [Test, Order(0)]
        public void VerifyBillingPage()
        {

            LoginPage login = new LoginPage(driver);
            login.ClkLogin();
            login.TypeUsername();
            login.TypePassword();
            login.ClickLoginButton();
            Thread.Sleep(3000);

            BillingPage clkBilling = new BillingPage(driver);
            clkBilling.HoverBillingOption(); 
            clkBilling.ClkBillingOp();
            clkBilling.ClkPayMethod();
            clkBilling.ClkAddPayMethod();
            //clkBilling.ClkAddPayMethodtab();

            //Scroll Down
           // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           //js.ExecuteScript("window.scrollTo(100, document.body.scrollHeight)");

            Thread.Sleep(5000);
            //clkBilling.ClkAddPayMethodtab();
            

           // clkBilling.AddCardHolderName_();
           // clkBilling.AddCardNum_();
            // driver.Quit();
        }
    }
}
