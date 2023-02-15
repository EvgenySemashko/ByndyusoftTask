using OpenQA.Selenium;

namespace ByndyusoftTest.Utils
{
    public static class ElementFactory
    {
        public static IWebElement GetElement(By by)
        {
            return BrowserManager.GetWebDriver().FindElement(by);
        }

        public static IEnumerable<IWebElement> GetElements(By by)
        {
            return BrowserManager.GetWebDriver().FindElements(by);
        }
    }
}
