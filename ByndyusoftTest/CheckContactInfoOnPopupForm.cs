using ByndyusoftTest.PageObjects;
using ByndyusoftTest.TestUtils;
using NUnit.Framework;

namespace ByndyusoftTest
{
    public class CheckContactInfoOnPopupForm : BaseTest
    {
        private GoogleSearchFormPage googleSearchFormView = new GoogleSearchFormPage();
        private GoogleSearchResultsPage googleSearchResultsView = new GoogleSearchResultsPage();
        private ByndyusoftMainPage byndyusoftMainPage = new ByndyusoftMainPage();

        [TestCase("Byndyusoft", "8 800 775-15-21", "sales@byndyusoft.com")]
        public void CheckContactInfoOnSite(string siteNameToNavigate, string expectedNumberPhone, string expectedEmail)
        {
            googleSearchFormView.PerformSearch(siteNameToNavigate);
            googleSearchResultsView.OpenFirstLink();
            byndyusoftMainPage.ClickOnRequestPresentation();
            Assert.That(byndyusoftMainPage.PopupContactInfo.GetContactEmail(), Is.EqualTo(expectedEmail), "Contact email is not equal");
        }
    }
}