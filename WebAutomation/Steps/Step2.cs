using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Step2
    {
        public static void FocusTab (IWebDriver driver)
        {
            driver.FindElement(By.Id("Box3")).Click();

            //Hit tab key
            driver.FindElement(By.Id("Box3")).SendKeys(Keys.Tab);

            SetMethods.AcceptAlert(driver);
        }
    }
}
