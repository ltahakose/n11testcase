using N11TestCase.BaseClasses;
using N11TestCase.PageObjects;
using NUnit.Framework;
using System.Threading;

namespace N11TestCase.TestScripts
{
    public class TestCase1 : BaseTest
    {

        [Test, Order(1)]
        public void Login()
        {
            HomePage.Login();
        }

        [Test, Order(2)]
        public void Search()
        {
            HomePage.Search();
        }

        [Test, Order(3)]
        public void SearchCheck()
        {
            HomePage.SearchCheck();
        }


        [Test, Order(4)]
        public void GoToSecondPage()
        {
            HomePage.GoToSecondPage();
        }


        [Test, Order(5)]
        public void SecondPageCheck()
        {
            HomePage.SecondPageCheck();
        }

        [Test, Order(6)]
        public void AddFavorite()
        {
            HomePage.AddFavorite();
        }

        [Test, Order(7)]
        public void MyFavorites()
        {
            HomePage.MyFavorites();
        }

        [Test, Order(8)]
        public void MyFavoritesCheck()
        {
            HomePage.MyFavoritesCheck();
        }

        [Test, Order(9)]
        public void DeleteFavorite()
        {
            HomePage.DeleteFavorite();
        }

        [Test, Order(10)]
        public void DeletedFavoriteCheck()
        {
            HomePage.DeletedFavoriteCheck();
        }

        [OneTimeTearDown]
        public void Exit()
        {
            Thread.Sleep(10000);
            Driver.Quit();
        }
    }
}
