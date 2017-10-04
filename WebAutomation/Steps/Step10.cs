using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Step10
    {
        public static void ClickStep10(IWebDriver driver)
        {
            driver.FindElement(By.Id("Box10")).Click();

            SetMethods.AcceptAlert(driver);
        }
    }
}
