using OpenQA.Selenium;

namespace PageObjects
{
    public class SchedulePage : BasePage
    {
        public SchedulePage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnSelectPlaces => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/main/div[2]/div[3]/div[2]/div[1]/div[3]/div/div[1]/div/div[4]/div[2]/form/a"));
        
        public void ClickConfirmStation() => btnSelectPlaces.Click();
    }
}
