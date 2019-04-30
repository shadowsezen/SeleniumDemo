using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UITests
{
    [Binding]
    public class WebTestsSteps
    {
        private IWebDriver _webDriver = null;
        private WebDriverWait wait = null;

        [Given(@"I am on Google")]
        public void GivenIAmOnGoogle()
        {
            _webDriver.Navigate().GoToUrl("http://www.google.com");
        }
        
        [When(@"I search for weather")]
        public void WhenISearchForWeather()
        {
            _webDriver.FindElement(By.ClassName("gLFyf")).SendKeys("weather");

            //using the Enter key is more reliable than interacting with the Search button
            _webDriver.FindElement(By.ClassName("gLFyf")).SendKeys(Keys.Return);
        }

        [When(@"I search for carrots")]
        public void WhenISearchForCarrots()
        {
            _webDriver.FindElement(By.ClassName("gLFyf")).SendKeys("carrots");

            //using the Enter key is more reliable than interacting with the Search button
            _webDriver.FindElement(By.ClassName("gLFyf")).SendKeys(Keys.Return);
        }

        [When(@"I click the Wikipedia link")]
        public void WhenIClickTheWikipediaLink()
        {
            _webDriver.FindElement(By.PartialLinkText("Wikipedia")).Click();

            wait.Until(d => { return _webDriver.FindElement(By.LinkText("Daucus carota")); });
        }

        [Then(@"the weather should display")]
        public void ThenTheWeatherShouldDisplay()
        {
            var temperature = _webDriver.FindElement(By.Id("wob_tm"));

            //basic assert to see that a value is present for the temperature
            Assert.IsNotNull(temperature);
        }

        [Then(@"I should be able to learn about carrots")]
        public void ThenIShouldBeAbleToLearnAboutCarrots()
        {
            var heading = _webDriver.FindElement(By.Id("firstHeading"));
            Assert.AreEqual("Carrot", heading.Text);
        }


        [BeforeScenario]
        public void CreateTestDriver()
        {
            _webDriver = new ChromeDriver();

            //Set it up so that whenever you tell Selenium to wait, it will wait at most 10 seconds trying to find whatever you tell it to find
            wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));

            //run the browser maximised to prevent view issues
            _webDriver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void DisposeOfWebDriver()
        {
            _webDriver.Dispose();
        }
    }
}
