using OpenQA.Selenium;

namespace PageObjects
{
    public class AuthorizationPage : BasePage
    {
        public AuthorizationPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement checkAuthorizationAlertText => driver.FindElement(By.XPath("//p [@class='sch-alert__text']"));

        public string GetAlertText() => checkAuthorizationAlertText.Text;
    }
}
