using ByndyusoftTest.Utils;
using OpenQA.Selenium;

namespace ByndyusoftTest.PageObjects
{
    public class GoogleSearchResultsPage
    {
        private List<IWebElement> SearchResults=> ElementFactory.GetElements(By.TagName("h3")).ToList();

        public void OpenFirstLink()
        {
            SearchResults[0].Click();
        }
    }
}
