using OpenQA.Selenium;

namespace N11TestCase.BaseClasses
{
    public abstract class BasePage
    {
        private IWebDriver _driver;

        protected IWebDriver Driver => _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}
