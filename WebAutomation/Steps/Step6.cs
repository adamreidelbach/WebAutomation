using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Step6
    {
        public static void InsertSubmitResult(IWebDriver driver)
        {
            string lineNum = driver.FindElement(By.Id("lineNum")).Text;

            // Create instance of Javascript executor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Identify the WebElement which will appear after scrolling down
            IWebElement elementLocal = driver.FindElement(By.XPath("(//strong[text()='Line "+lineNum+":'])"));

            // now execute query which actually will scroll until that element is not appeared on page.
            js.ExecuteScript("arguments[0].scrollIntoView(true);", elementLocal);

            //get result from previous text
            var result = Step5.CaptureText(driver);

            //scroll down to correct input field and enter the cpatured text
            driver.FindElement(By.XPath("(//input[@type='text'])[" + lineNum + "]")).Clear();
            driver.FindElement(By.XPath("(//input[@type='text'])[" + lineNum + "]")).SendKeys(result);

            //Hit enter key
            driver.FindElement(By.XPath("(//input[@type='text'])[" + lineNum + "]")).SendKeys(Keys.Enter);

            SetMethods.AcceptAlert(driver);
        }
    }
}
