using N11TestCase.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace N11TestCase.BaseClasses
{
    public class BaseTest
    {
        public IWebDriver Driver;
        public WebDriverWait wait;
        public HomePage HomePage;

        [OneTimeSetUp]
        public void SetUp()
        {
            var geckoPath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(geckoPath, "geckodriver.exe");
            var programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Replace(" (x86)", "");
            service.FirefoxBinaryPath = $@"{programFilesPath}\Mozilla Firefox\firefox.exe";
            Driver = new FirefoxDriver(service);
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.n11.com/";
            HomePage = new HomePage(Driver);
        }
    }
}
