using OpenQA.Selenium;

namespace PageObjects
{
    public class OnlineScoreboardPage : BasePage
    {
        public OnlineScoreboardPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnConfirmStation => driver.FindElement(By.XPath("//input[@value='Да']"));
        private IWebElement checkStation => driver.FindElement(By.XPath("//*[@id=\"cityPopupTrigger\"]/span"));
        
        public void ClickConfirmStation() => btnConfirmStation.Click();
        public string GetStationName() => checkStation.Text;
    }
}
