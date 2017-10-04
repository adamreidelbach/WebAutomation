using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Step3
    {
        public static void DynamicRadioOption (IWebDriver driver)
        {
            var optionVal = driver.FindElement(By.Id("optionVal"));

            // Store all the elements of same category in the list of WebLements	
            IList<IWebElement> oRadioButton = driver.FindElements(By.Name("option"));

            //Turn option text into an interger and subtract one in order to find the corresponding index
            int optionNumber = Int32.Parse(optionVal.Text);
            int optionSelect = optionNumber - 1;
            
            //Given the index, click the correct radio button
            oRadioButton.ElementAt(optionSelect).Click();

            SetMethods.AcceptAlert(driver);
        }
    }
}
