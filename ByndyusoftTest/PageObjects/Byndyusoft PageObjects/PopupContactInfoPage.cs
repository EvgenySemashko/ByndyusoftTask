using ByndyusoftTest.Utils;
using OpenQA.Selenium;

namespace ByndyusoftTest.PageObjects
{
    public class PopupContactInfoPage
    {
        private IWebElement ContactEmailLabel => ElementFactory.GetElement(By.XPath("//div[contains(@class,'popup-callback__content')]//a[contains(@href,'mailto')]"));

        public string GetContactEmail()
        {
            return ContactEmailLabel.Text;
        }
    }
}
