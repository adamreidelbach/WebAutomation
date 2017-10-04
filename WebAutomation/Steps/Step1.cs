using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Step1
    {
        public static void ClickStep1 (IWebDriver driver)
        {
            //Click Box1
            driver.FindElement(By.Id("Box1")).Click();

            //Close alert
            SetMethods.AcceptAlert(driver);
        }
    }
}
