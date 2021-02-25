using System;

using TechTalk.SpecFlow;

namespace AulaBDD
{
    [Binding]
    public class ConverterSteps
    {
        [Given("A Celsius temperature of (.*)")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            ScenarioContext.Current.Pending();
        }

        [When("I get the Farenheit equivalent")]
        public void WhenIPressAdd()
        {
            //  (30°C x 1.8) + 32 = 86°F

            ScenarioContext.Current.Pending();
        }

        [Then("Then the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
