using AngleSharp.Html.InputTypes;
using NUnit.Framework;
using POMTest1.Base;
using POMTest1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMTest1.Test
{
    public class TestLogin : BaseClass
    {
        [Test, Order(0)]
        public void VerifyLogin()
        {
            LoginPage login = new LoginPage(driver);



            login.ClkLogin();
            login.TypeUsername();
            login.TypePassword();
            login.ClickLoginButton();
          

            Thread.Sleep(3000);
            //driver.Quit();
     

       

        }
    }
}



