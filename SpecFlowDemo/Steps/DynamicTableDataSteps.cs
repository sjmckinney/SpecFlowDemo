using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDemo.Features
{
    [Binding]
    public sealed class DynamicTableData
    {
        [Given(@"Pass a multi-row table to the step and display contents")]
        public void GivenPassAMulti_RowTableToTheStepAndDisplayContents(Table table)
        {
            var data = table.CreateDynamicSet();

            foreach (var country in data)
            {
                System.Console.WriteLine("Details of country: " + country.Name);
                System.Console.WriteLine("Capital: " + country.Capital);
                System.Console.WriteLine("Population: " + country.Population);
                System.Console.WriteLine("Hemisphere: " + country.Hemisphere + "\r\n");
            }
        }
    }
}
