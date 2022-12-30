using Autotestung.Driver;
using Autotestung.Services;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;

namespace Autotestung
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {

            driver = DrivarSingilton.GetWebDriver();
            driver.Navigate().GoToUrl("https://projectorochi.com");


        }

        [Test]////
        public void LearnMore()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            loginPage.LearnMoreButton();
        }

        [Test]////
        public void Support()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            loginPage.SupportButton();
        }
        [Test]////
        public void NearButton()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            loginPage.ClickByAuth();
        }

        [Test]////
        public void Shoping()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            loginPage.Shop();
        }

    }
}