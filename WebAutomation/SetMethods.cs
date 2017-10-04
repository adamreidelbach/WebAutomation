using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAutomation
{
    class SetMethods
    {
        //Accept Alert Box
        public static void AcceptAlert(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
