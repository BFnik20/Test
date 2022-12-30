using Autotestung.Model;
using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Page
{
    internal class LoginPage
    {
        private readonly By _SearchButton = By.XPath("/html/body/div[1]/div/div/div[2]/a[1]/span[1]");

        private readonly By _SearchInput = By.XPath("/html/body/div[1]/div/nav/div/div/div[1]/div/ul/li[2]/a/span[1]");
        private readonly By _SearchField = By.XPath("/html/body/div[1]/div/nav/div/div/div[2]/div/ul/li[2]/ul/li[2]/a/span");
        private readonly By _buy = By.XPath("/html/body/main/div/div/div[3]/div/div/div[1]/div[2]/div/div/a");

        private readonly By _comparer = By.XPath("/html/body/main/div[1]/div/div[2]/div/div/div/form/div[2]/button");
        private readonly By _ClosBaner = By.XPath("/html/body/main/div/div/form/ul/li[2]/div[2]/div[3]/div/a[1]");

        private readonly By _ButtonAuth = By.XPath("/html/body/main/div[1]/div/div/div[4]/div/div/div/div[3]/a");

        private readonly By _singButton = By.XPath("/html/body/div[1]/div/div/div[2]/a[1]/span[1]");

        private readonly By _LoginInutButton = By.XPath("/html/body/main/div[3]/div/div/div[2]/div[2]/div/details/summary");
        private readonly By _PasswordInutButton = By.XPath("//input[@name='password']");

        private readonly By _ButtonEnter = By.XPath("/html/body/main/div[1]/div/div[2]/div/div/div/form/div[2]/button");

        private readonly By _ErrorText = By.XPath("//p[@class='error___p']");
        private readonly By homePaheApple = By.XPath("/html/body/nav/div/ul[2]/li[5]/a");

        private readonly By learnMore = By.XPath("/html/body/main/div/div/div[3]/div/div/div[1]/div[1]/div/div/a");

        private readonly By phone = By.XPath("/html/body/div[8]/div/p/a[1]");
        private readonly By support = By.XPath("/html/body/div[1]/div/nav/div/div/div[1]/div/ul/li[5]/a/span");


        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory();
        private static readonly ILogger _logger = _loggerFactory.CreateLogger("CustomCategory");

        private IWebDriver driver;
        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void  Shop()
            {
        driver.FindElement(_SearchButton).Click();
        driver.FindElement(_SearchInput).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(_SearchField).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(_buy).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(_comparer).Click();
    }

        public void LearnMoreButton()
        {
            driver.FindElement(_ButtonAuth).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(learnMore).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(_ButtonEnter).Click();
        }

        public void SupportButton()
        {
            driver.FindElement(_ButtonAuth).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(learnMore).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(_ButtonEnter).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            driver.FindElement(phone).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(_ClosBaner).Click();

        }
        public void ClickByAuth()
        {
            {
                driver.FindElement(_singButton).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.FindElement(support).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                driver.FindElement(_LoginInutButton).Click();
            }
        }
        public void inputLogin(string _login)
        {
            _logger.LogInformation("inputLogin");
            var login = driver.FindElement(_LoginInutButton);
            login.SendKeys(_login);
        }
        public void inputPasword(string _pasword)
        {
            _logger.LogInformation("inputPasword");
            var password = driver.FindElement(_PasswordInutButton);
            password.SendKeys(_pasword);
        }
        public void ClickEnter()
        {
            _logger.LogInformation("ClickEnter");
            var enter = driver.FindElement(_ButtonEnter);
            enter.Click();
        }
        public String MessageErors;
        public void Massege()
        {
            _logger.LogInformation("Massege");
            var massege = driver.FindElement(_ErrorText);
            MessageErors = massege.Text;
        }
        
        public String Login(User user)
        {
            _logger.LogInformation("Start Login Test -------");
            ClickByAuth();
            inputLogin(user.Login);
            inputPasword(user.Password);
            ClickEnter();
            Massege();
            _logger.LogInformation("Massege = " + MessageErors);
            return MessageErors;
        }
    }
}
