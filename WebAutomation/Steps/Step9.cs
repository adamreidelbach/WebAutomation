using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Step9
    {
        public static void ClickStep9(IWebDriver driver)
        {
            driver.FindElement(By.Id("Box9")).Click();

            Thread.Sleep(5000);

            SetMethods.AcceptAlert(driver);
        }
    }
}
