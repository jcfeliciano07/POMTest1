using AngleSharp.Html.InputTypes;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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
    public class HomeTest : BaseClass

    {
        [Test, Order(0)]
        public void VerifyCreateNewSite()
        {

            LoginPage login = new LoginPage(driver);
            login.ClkLogin();
            login.TypeUsername();
            login.TypePassword();
            login.ClickLoginButton();
            Thread.Sleep(3000);

            HomePage clkfromHome = new HomePage(driver);
            clkfromHome.ClkCreateNewSite();
            clkfromHome.ClkWhoOwnSite();
            clkfromHome.HoverManage();
            clkfromHome.ClkBluePrint();
            clkfromHome.HoverAcctOption();
            clkfromHome.ClkAcctOp();

            driver.Quit();
        }
    }
}


