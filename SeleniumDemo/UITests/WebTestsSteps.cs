using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UITests
{
    [Binding]
    public class WebTestsSteps
    {
        private IWebDriver _webDriver = null;

        [Given(@"I am on Google")]
        public void GivenIAmOnGoogle()
        {
            _webDriver.Navigate().GoToUrl("www.google.com");
        }
        
        [When(@"I search for weather")]
        public void WhenISearchForWeather()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the weather should display")]
        public void ThenTheWeatherShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }

        [BeforeScenario]
        public void CreateTestDriver()
        {
            _webDriver = new ChromeDriver();
        }

        [AfterScenario]
        public void DisposeOfWebDriver()
        {
            _webDriver.Dispose();
        }
    }
}
