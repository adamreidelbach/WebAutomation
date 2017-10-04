using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WebAutomation
{
    class Step5
    {
        public static void PlaceholderText (IWebDriver driver)
        {
            // get and write formDate text
            var formDateText = driver.FindElement(By.Id("formDate")).GetAttribute("placeholder");
            driver.FindElement(By.Id("formDate")).SendKeys(formDateText);

            // get and write formCity text
            var formCityText = driver.FindElement(By.Id("formCity")).GetAttribute("placeholder");
            driver.FindElement(By.Id("formCity")).SendKeys(formCityText);

            // get and write formState text
            var formStateText = driver.FindElement(By.Id("formState")).GetAttribute("placeholder");
            driver.FindElement(By.Id("formState")).SendKeys(formStateText);

            // get and write formCountry text
            var formCountryText = driver.FindElement(By.Id("formCountry")).GetAttribute("placeholder");
            driver.FindElement(By.Id("formCountry")).SendKeys(formCountryText);

            // get and write formDate2 text
            var formDateText2 = driver.FindElement(By.XPath("(//input[@id='formDate'])[2]")).GetAttribute("placeholder");
            driver.FindElement(By.XPath("(//input[@id='formDate'])[2]")).SendKeys(formDateText2);

            // get and write formDate2 text
            var formCityText2 = driver.FindElement(By.XPath("(//input[@id='formCity'])[2]")).GetAttribute("placeholder");
            driver.FindElement(By.XPath("(//input[@id='formCity'])[2]")).SendKeys(formCityText2);

            // get and write formState2 text
            var formStateText2 = driver.FindElement(By.XPath("(//input[@id='formState'])[2]")).GetAttribute("placeholder");
            driver.FindElement(By.XPath("(//input[@id='formState'])[2]")).SendKeys(formStateText2);

            // get and write formCountry2 text
            var formCountryText2 = driver.FindElement(By.XPath("(//input[@id='formCountry'])[2]")).GetAttribute("placeholder");
            driver.FindElement(By.XPath("(//input[@id='formCountry'])[2]")).SendKeys(formCountryText2);

            // get and write formDate3 text
            var formDateText3 = driver.FindElement(By.XPath("(//input[@id='formDate'])[3]")).GetAttribute("placeholder");
            driver.FindElement(By.XPath("(//input[@id='formDate'])[3]")).SendKeys(formDateText3);

            //click button
            driver.FindElement(By.XPath("(//button[text()='Submit'])")).Click();

            //close alert
            SetMethods.AcceptAlert(driver);
        }

        public static string CaptureText (IWebDriver driver)
        {
            //capture formResult text
            var formResult = driver.FindElement(By.Id("formResult")).Text;

            return formResult;
        }
    }
}
