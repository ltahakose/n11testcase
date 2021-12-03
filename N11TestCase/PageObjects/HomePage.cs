using N11TestCase.BaseClasses;
using N11TestCase.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace N11TestCase.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SignInButton => TestCaseHelper.FindElementByClassName("btnSignIn", Driver);
        public IWebElement EmailArea => TestCaseHelper.FindElementById("email", Driver);
        public IWebElement PasswordArea => TestCaseHelper.FindElementById("password", Driver);
        public IWebElement LoginButton => TestCaseHelper.FindElementById("loginButton", Driver);
        public IWebElement SearchArea => TestCaseHelper.FindElementById("searchData", Driver);
        public IWebElement SearchButton => TestCaseHelper.FindElementByClassName("searchBtn", Driver);
        public IWebElement ResultText => TestCaseHelper.FindElementByClassName("resultText", Driver);
        public IWebElement SecondPageButton => TestCaseHelper.FindElementByXPath("//*[@id=\"contentListing\"]/div/div/div[2]/div[5]/a[2]", Driver);
        public IWebElement SecondPageActiveButton => TestCaseHelper.FindElementByXPath("//*[@id=\"contentListing\"]/div/div/div[2]/div[5]/a[3]", Driver);
        public IWebElement FavoriteButton => TestCaseHelper.FindElementByXPath("/html/body/div[1]/div[3]/div/div/div[2]/section[2]/div[2]/ul/li[3]/div/div[1]/span", Driver);
        public IWebElement MyAccountButton => TestCaseHelper.FindElementByClassName("myAccount", Driver);
        public IWebElement BackToTopButton => TestCaseHelper.FindElementById("btnScrollTop", Driver);
        public IWebElement MyFavoritesButton => TestCaseHelper.FindElementByXPath("/html/body/div[1]/header/div/div/div[2]/div[2]/div[2]/div[2]/div/a[2]", Driver);
        public IWebElement MyFavoriteList => TestCaseHelper.FindElementByClassName("listItemTitle", Driver);
        public IWebElement MyFavoriteProductList => TestCaseHelper.FindElementByXPath("//*[@id=\"myAccount\"]/div[2]/ul/li[1]/div/a", Driver);
        public IWebElement DeleteFavoriteButton => TestCaseHelper.FindElementByClassName("deleteProFromFavorites", Driver);
        public IWebElement DeletedFavoriteMessageArea => TestCaseHelper.FindElementByClassName("message", Driver);
        public IWebElement OkayButton => TestCaseHelper.FindElementByClassName("btnHolder", Driver);


        public void Login()
        {
            SignInButton.Click();
            Thread.Sleep(3000);
            EmailArea.SendKeys(UserSettingsHelper.EMAIL);
            Thread.Sleep(500);
            PasswordArea.SendKeys(UserSettingsHelper.PASSWORD);
            Thread.Sleep(500);
            LoginButton.Click();
        }

        public void Search()
        {
            SearchArea.SendKeys("Samsung");
            Thread.Sleep(500);
            SearchButton.Click();
            Thread.Sleep(3000);
        }

        public void SearchCheck()
        {
            Assert.IsTrue(ResultText.Text.Contains("Samsung") && ResultText.Text.Contains("bulundu"));
        }

        public void GoToSecondPage()
        {
            SecondPageButton.Click();
            Thread.Sleep(1000);
        }

        public void SecondPageCheck()
        {
            Assert.IsTrue(SecondPageActiveButton.GetAttribute("class").Contains("active"));
        }

        public void AddFavorite()
        {
            FavoriteButton.Click();
        }

        public void MyFavorites()
        {
            BackToTopButton.Click();
            Thread.Sleep(500);
            Actions action = new Actions(Driver);
            action.MoveToElement(MyAccountButton).Perform();
            Thread.Sleep(1000);
            MyFavoritesButton.Click();
        }

        public void MyFavoritesCheck()
        {
            Assert.IsTrue(MyFavoriteList.Text.Contains("Favorilerim (1)"));
        }

        public void DeleteFavorite()
        {
            MyFavoriteProductList.Click();
            Thread.Sleep(2000);
            DeleteFavoriteButton.Click();
        }

        public void DeletedFavoriteCheck()
        {
            Assert.IsTrue(DeletedFavoriteMessageArea.Text.Contains("Ürününüz listeden silindi."));
            Thread.Sleep(3000);
            OkayButton.Click();
        }
    }
}
