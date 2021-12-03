using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace N11TestCase.Helper
{
    public static class TestCaseHelper
    {
        public static IWebElement FindElementByXPath(string element, IWebDriver driver)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.IgnoreExceptionTypes();
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }
        }

        public static IWebElement FindElementById(string element, IWebDriver driver)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.IgnoreExceptionTypes();
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }
        }

        public static IWebElement FindElementByName(string element, IWebDriver driver)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.IgnoreExceptionTypes();
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }
        }

        public static IWebElement FindElementByClassName(string element, IWebDriver driver)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.IgnoreExceptionTypes();
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }
        }
    }
}
