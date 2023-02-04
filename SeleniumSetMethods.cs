using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1752
{
    class SeleniumSetMethods
    {
        public static void FindText(IWebDriver driver, string element, string value, string elementtype, string xpathT)
        {
            bool Display = false;
            bool Enable = false;
            IWebElement ele = driver.FindElement(By.XPath(xpathT));
            Display = ele.Displayed;
            Enable = ele.Enabled;

            if (Display == true && Enable == true)
            {
                if (String.IsNullOrEmpty(ele.GetAttribute("value")))
                {
                    if (elementtype == "Id")
                        driver.FindElement(By.Id(element)).SendKeys(value);
                    if (elementtype == "Name")
                        driver.FindElement(By.Id(element)).SendKeys(value);
                    Console.WriteLine("TextBox " + element + " exists and is enabled");
                }
            }
            else
                Console.WriteLine("TextBox " + element + " not enabled/ doesn't exist");
        }

        public static void FindButton(IWebDriver driver, string element, string elementtype, string xpathB)
        {
            bool Display = false;
            bool Enable = false;
            IWebElement ele = driver.FindElement(By.XPath(xpathB));
            Display = ele.Displayed;
            Enable = ele.Enabled;

            if (Display == true && Enable == true)
            {
                if (elementtype == "Id")
                    driver.FindElement(By.Id(element)).Click();
                if (elementtype == "Name")
                    driver.FindElement(By.Name(element)).Click();
                Console.WriteLine("Button " + element + " exists and is enabled");
            }
            else
                Console.WriteLine("Button  " + element + "  not enabled/ doesn't exist");
        }
    }
}
