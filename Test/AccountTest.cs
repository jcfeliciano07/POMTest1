﻿using NUnit.Framework;
using POMTest1.Base;
using POMTest1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTest1.Test
{
    public class AccountTest : BaseClass
    {

        [Test, Order(0)]
        public void VerifyAccountPage()
        {

            LoginPage login = new LoginPage(driver);
            login.ClkLogin();
            login.TypeUsername();
            login.TypePassword();
            login.ClickLoginButton();
            Thread.Sleep(3000);

            HomePage clkAccount = new HomePage(driver);
            clkAccount.HoverAcctOption();
            clkAccount.ClkAcctOp();


        }
    }
}
