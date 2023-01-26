using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POMTest1.Pages
{
    public class BillingPage
    {
        IWebDriver driver;

        By ClkBilling = By.CssSelector("a[title='Billing']");
        By ClkPayMeth = By.LinkText("Payment Methods");
        By ClkAddPayMeth = By.CssSelector("h6[class='--alt']");
       // By clickPayMethTab = By.XPath("//button[@id='payment-type-tab-0']//span[@class='MuiTab-wrapper']");
        By AddCardHolderName = By.CssSelector("#cardholderName");
        By AddCardNum = By.CssSelector("#creditCardNumber");


        public BillingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void HoverBillingOption() //Mouse Hover function
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.TagName("img"))).Click().Build().Perform();
        }

        public void ClkBillingOp()
        {
            driver.FindElement(ClkBilling).Click();
        }
        public void ClkPayMethod()
        {
            driver.FindElement(ClkPayMeth).Click();
        }
        public void ClkAddPayMethod()
        {
            driver.FindElement(ClkAddPayMeth).Click();
        }
        //public void ClkAddPayMethodtab()
        //{
        ////driver.FindElement(clickPayMethTab).Click();
        //}
        public void AddCardHolderName_()
        {
            driver.FindElement(AddCardHolderName).SendKeys("Selenium Automation");
        }
        public void AddCardNum_()
        {
            driver.FindElement(AddCardNum).SendKeys("5245225236364646");
        }
    }
}
