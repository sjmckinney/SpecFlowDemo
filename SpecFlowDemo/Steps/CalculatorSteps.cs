using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDemo
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Number to sum: " + number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Pressed Add button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            //ScenarioContext.Current.Pending();
            if (result == 120)
            {
                Console.WriteLine("The test PASSED");
            }
            else
            {
                Console.WriteLine("The test FAILED");
                throw new Exception("TEST FAILED");
            }
        }
    }
}

