using ByndyusoftTest.Models;
using ByndyusoftTest.Resources;
using ByndyusoftTest.Utils;
using NUnit.Framework;
using static ByndyusoftTest.Utils.JsonReader;

namespace ByndyusoftTest.TestUtils
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            BrowserManager.GetWebDriver().Navigate().GoToUrl(JsonReader.GetDeserializedObject<ConfigurationModel>(ConstantPathToFiles.ConfigurationFile, FormatString.Path).Host);
        }

        [TearDown]
        public void Teardown()
        {
            BrowserManager.QuitBrowser();
        }
    }
}
