using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AulaBDD
{
    [Binding]
    public class TestSteps
    {
        private readonly Calculator _calculator;

        public TestSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int firstNumber)
        {
            _calculator.FirstNumber = firstNumber;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int secondNumber)
        {
            _calculator.SecondNumber = secondNumber;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _calculator.Add();
        }

        [Then(@"The result should be (.*) on the screen")]
        public void ThenTheResltShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculator.Result);
        }
    }
}
