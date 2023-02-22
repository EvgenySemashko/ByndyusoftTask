using ByndyusoftTest.Utils;
using OpenQA.Selenium;

namespace ByndyusoftTest.PageObjects
{
    public class ByndyusoftMainPage
    {
        private IWebElement RequestPresentationButton => ElementFactory.GetElement(By.XPath("//div[contains(@class,'know-more')]//*[contains(@class,'btn')]"));

        public PopupContactInfoPage PopupContactInfo { get; set; }

        public ByndyusoftMainPage()
        {
            PopupContactInfo = new PopupContactInfoPage();
        }

        public void ClickOnRequestPresentation()
        {
            RequestPresentationButton.Click();
        }
    }
}
