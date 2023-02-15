using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ByndyusoftTest.Utils
{
    public static class BrowserManager
    {
        private static WebDriver driver = null;

        public static WebDriver GetWebDriver()
        {
            if (driver == null)
            {
                InitializeChromeDriver();
            }

            return driver;
        }

        public static void QuitBrowser()
        {
            driver.Quit();
            driver = null;
        }

        private static void InitializeChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
    }
}
