using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenBrowserWithAutomation("https://www.google.com/ncr");
        }
        private static void OpenBrowserWithAutomation(string url){
            try
            {
                using (IWebDriver driver = new FirefoxDriver()){
                
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                    driver.Navigate().GoToUrl(url);
                    driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);
                    wait.Until(webDriver => webDriver.FindElement(By.CssSelector("h3")).Displayed);
                    IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));
                    
                    Console.WriteLine(firstResult.GetAttribute("textContent"));
                    Console.ReadKey();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
