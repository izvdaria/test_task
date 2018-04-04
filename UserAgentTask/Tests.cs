using System.Collections.Generic;
using OpenQA.Selenium;
using Tests;
using Xunit;

namespace UserAgentTask
{
    public class Tests
    {
        [Fact]
        public void VerifyMenuButtonIsNotPresent()
        {
            var driver = new Driver();
            driver.Navigate();

            var menuButton = driver.WebDriver.FindElement(By.Id("dl-menu"));

            Assert.False(menuButton.Displayed);

            driver.Close();
        }

        [Fact]
        public void VerifyLinksAreDisplayed()
        {
            var driver = new Driver();
            driver.Navigate();

            var links = new List<IWebElement>();

            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'HOME']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'TUTORIALS']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'PRACTICE']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'SELENIUM']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'CUCUMBER']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'PYTHON']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'FORUMS']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'ABOUT']")));
            links.Add(driver.WebDriver.FindElement(By.XPath("//ul[@id='main-nav']//span[text() = 'CONTACT']")));

            links.ForEach(e => Assert.True(e.Displayed));

            driver.Close();
        }
    }
}
