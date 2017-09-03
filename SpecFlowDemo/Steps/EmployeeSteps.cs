using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDemo.Steps
{
    [Binding]
    public sealed class EmployeeSteps
    {
        [Given(@"I pass a table to the step definition")]
        public void GivenIPassATableToTheStepDefinition(Table table)
        {
            Console.WriteLine("Number of table rows: " + table.RowCount + "\r\n");
            EmployeeDetails employeeDetails = table.CreateInstance<EmployeeDetails>();
            Console.WriteLine(employeeDetails.Name);
            Console.WriteLine(employeeDetails.Age);
            Console.WriteLine(employeeDetails.Phone);
            Console.WriteLine(employeeDetails.Email);
        }

        [Given(@"I pass a multi-row table to the step definition")]
        public void GivenIPassAMulti_RowTableToTheStepDefinition(Table table)
        {
            var employeeDetails = table.CreateSet<EmployeeDetails>();

            foreach (EmployeeDetails emp in employeeDetails)
            {
                Console.WriteLine("Details of employee: " + emp.Name);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Phone);
                Console.WriteLine(emp.Email + "\r\n");
            }
        }

        [Given(@"I pass (.*), (.*), (.*) and (.*) to the step definition")]
        public void GivenIPassSteveMcKinneyAndStevejmckinneyGmail_ComToTheStepDefinition(string name, int age, string phone, string email)
        {
            Console.WriteLine("Details of employee: " + name);
            Console.WriteLine(age);
            Console.WriteLine(phone);
            Console.WriteLine(email + "\r\n");
        }

    }
}
