using System;
using TechTalk.SpecFlow;

namespace UITests
{
    [Binding]
    public class WebTestsSteps
    {
        [Given(@"I am on Google")]
        public void GivenIAmOnGoogle()
        {
            ScenarioContext.Current.Pending();
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
    }
}
