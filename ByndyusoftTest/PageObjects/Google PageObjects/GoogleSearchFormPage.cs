using ByndyusoftTest.Utils;
using OpenQA.Selenium;

namespace ByndyusoftTest.PageObjects
{
    public class GoogleSearchFormPage
    {
        private IWebElement SearchBar => ElementFactory.GetElement(By.Name("q"));

        public void PerformSearch(string searchText)
        {
            SearchBar.SendKeys(searchText);
            SearchBar.SendKeys(Keys.Return);
        }
    }
}
