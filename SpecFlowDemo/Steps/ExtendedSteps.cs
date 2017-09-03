using System;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Steps
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly Country country;

        public ExtendedSteps(Country country)
        {
            this.country = country;
        }

        [Then(@"I should be able to access them in this step")]
        public void ThenIShouldBeAbleToAccessThemInThisStep()
        {
            Console.WriteLine("Details for: " + country.Name);
            Console.WriteLine("Capitla: " + country.Capital);
            Console.WriteLine("Population: " + country.Population);
            Console.WriteLine("Hemisphere: " + country.Hemisphere);
        }

    }
}
