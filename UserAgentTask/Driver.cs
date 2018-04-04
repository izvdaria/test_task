using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Driver
    {
        private IWebDriver _driver;

        public Driver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--user-agent=Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            options.AddArguments("--window-size=1000,850");

            _driver = new ChromeDriver(options);
        }

        public IWebDriver WebDriver => _driver;

        public void Navigate()
        {
            var url = "http://www.seleniumframework.com/intermediate-tutorial/override-useragent/";
            WebDriver.Navigate().GoToUrl(url);
        }

        public void Close()
        {
            WebDriver.Quit();
        }
    }
}
