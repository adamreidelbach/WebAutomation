using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Program
    {

        static void Main(string[] args)
        {
            //Create browser reference
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://hpa.services/automation-challenge");

            Step1.ClickStep1(driver);
            Step2.FocusTab(driver);
            Step3.DynamicRadioOption(driver);
            Step4.DynamicSelectBox(driver);
            Step5.PlaceholderText(driver);
            Step6.InsertSubmitResult(driver);
            Step7.ClickStep7(driver);
            Step8.ClickStep8(driver);
            Step9.ClickStep9(driver);
            Step10.ClickStep10(driver);
        }

    }
}
