using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Step4
    {
        public static void DynamicSelectBox(IWebDriver driver)
        {
            // select the drop down list
            var selectBox = driver.FindElement(By.TagName("select"));
            //create select element object 
            var selectElement = new SelectElement(selectBox);

            var selectVal = driver.FindElement(By.Id("selectionVal"));
            //select by value
            selectElement.SelectByValue(selectVal.Text);

            //close alert
            SetMethods.AcceptAlert(driver);
        }
    }
}
