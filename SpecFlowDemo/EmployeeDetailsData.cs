using System.Collections.Generic;

namespace SpecflowDemo
{
    class EmployeeDetailsData
    {
        public List<EmployeeDetails> EmployeeList = new List<EmployeeDetails>()
        {
            new EmployeeDetails()
            {
                Name = "John Smith",
                Age = 32,
                Phone = "01275 463233",
                Email = "jsmith@gamil.com"
            },
             new EmployeeDetails()
            {
                Name = "Jane Doe",
                Age = 21,
                Phone = "01275 463256",
                Email = "jdoe@gamil.com"
            },
            new EmployeeDetails()
            {
                Name = "Seth Meyers",
                Age = 65,
                Phone = "01275 465789",
                Email = "smeyers@gamil.com"
            }
        };  
    }
}
