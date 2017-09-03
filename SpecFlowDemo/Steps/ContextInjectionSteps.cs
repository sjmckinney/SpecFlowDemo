using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDemo.Steps
{
    [Binding]
    public sealed class ContextInjection
    {
        public Country country;

        public ContextInjection(Country country)
        {
            this.country = country;
        }

        [Given(@"The country's details are passed in this step")]
        public void GivenTheCountrySDetailsArePassedInThisStep(Table table)
        {
            var data = table.CreateDynamicSet();

            foreach (var item in data)
            {
                country.Name = (string)item.Name;
                country.Capital = (string)item.Capital;
                country.Population = (Int32)item.Population;
                country.Hemisphere = (string)item.Hemisphere;
            }
        }
    }
}
