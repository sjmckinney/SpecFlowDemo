using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Steps
{
    [Binding]
    public sealed class ScenarioContextSteps
    {
        [Given(@"I pass this value (.*) in this step")]
        public void GivenIPassThisValueInThisStep(string storedValue)
        {
            ScenarioContext.Current["StoredValue"] = storedValue;
            System.Console.WriteLine("Value supplied to ScenarioContext is: " + storedValue);
        }

        [Then(@"Display stored value in this step")]
        public void ThenDisplayStoredValueInThisStep()
        {
            System.Console.WriteLine("ScenarioContext value is: " + ScenarioContext.Current["StoredValue"]);
        }

        [Given(@"I assign complex data type in this step")]
        public void GivenIAssignComplexDataTypeInThisStep()
        {
            EmployeeDetailsData listOfEmployeeDetails = new EmployeeDetailsData();
            ScenarioContext.Current.Add("employeeDetailsList", listOfEmployeeDetails);
        }


        [Then(@"Display stored values in this step")]
        public void ThenDisplayStoredValuesInThisStep()
        {
            var employeeListData = ScenarioContext.Current.Get<EmployeeDetailsData>("employeeDetailsList");
            var employeeList = employeeListData.EmployeeList;

            foreach (EmployeeDetails emp in employeeList)
            {
                System.Console.WriteLine("Employee details for: " + emp.Name);
                System.Console.WriteLine("Employee age is: " + emp.Age);
                System.Console.WriteLine("Employee phone is: " + emp.Phone);
                System.Console.WriteLine("Employee email is: " + emp.Email + "\n\r");
            }
        }

        [Given(@"this is value of the current ScenarioInfo")]
        public void GivenThisIsValueOfTheCurrentScenarioInfo()
        {
            System.Console.WriteLine("ScenarioInfo");
            System.Console.WriteLine("ScenarioInfo.Title: " + ScenarioContext.Current.ScenarioInfo.Title);
            System.Console.WriteLine("ScenarioInfo.Tags: " + "[{0}", string.Join(", ", ScenarioContext.Current.ScenarioInfo.Tags) + "]\n\r");
        }

        [Given(@"this is value of the current ScenarioBlock")]
        public void GivenThisIsValueOfTheCurrentScenarioBlock()
        {
            System.Console.WriteLine("ScenarioBlock");
            System.Console.WriteLine(" ScenarioContext.Current.CurrentScenarioBlock.ToString(): " + ScenarioContext.Current.CurrentScenarioBlock.ToString() + "\n\r");
        }


    }
}
