using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PageObjects
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnOnlineScoreboard => driver.FindElement(By.XPath("//span[text()='Онлайн-табло']"));
        private IWebElement btnWhenTomorrow => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[2]/div/div[2]/a[2]"));
        private IWebElement btnSearch => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[3]/button"));
        
        private IWebElement inputFrom => driver.FindElement(By.XPath("//input[@id='one-way-raspFormFromTitle']"));
        private IWebElement inputTo => driver.FindElement(By.XPath("//input[@id='one-way-raspFormToTitle']"));
        private IWebElement inputWhen => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[1]/div[3]/div/div/div[1]/div[2]/div/div/div[2]/div/div/div[2]/div[1]/form/div/div[2]/div/div[1]/input[1]"));

        public void ClickOnlineScoreboard() => btnOnlineScoreboard.Click();
        public void ClickBtnTomorrow() => btnWhenTomorrow.Click();
        public void ClickBtnSearch() => btnSearch.Click();

        public void SendTextToFrom(string text) => inputFrom.SendKeys(text);
        public void SendTextToTo(string text) => inputTo.SendKeys(text);
        public void SendTextToWhen(string text) => inputWhen.SendKeys(text);
    }
}
