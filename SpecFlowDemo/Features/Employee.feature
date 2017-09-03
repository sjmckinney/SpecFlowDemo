Feature: Use of tables to provide data to step definitions
	EmployeeDetails class contains fields Name, Age, Phone and Email
	Scenario 1 creates single instance of EmployeeDetails using; EmployeeDetails employeeDetails = table.CreateInstance<EmployeeDetails>();
	Scenario 2 creates multiple instances of EmployeeDetails using; var employeeDetails = table.CreateSet<EmployeeDetails>();
	Scenario 3 use of Examples table in Scenario Outline creates a seperate test for each row of data

Scenario: 1.Transfrom table row data into class
	Given I pass a table to the step definition
	| Name           | Age | Phone        | Email                    |
	| Steve McKinney | 54  | 07807 359194 | stevejmckinney@gmail.com | 


Scenario: 2.Transfrom table data with multiple rows
	Given I pass a multi-row table to the step definition
	| Name           | Age | Phone        | Email						|
	| Steve McKinney | 54  | 07807 359194 | stevejmckinney@gmail.com	|
	| John McKinney	 | 52  | 07807 123456 | johnamckinney@gmail.com		|
	| Dick McKinney	 | 48  | 07807 654321 | richardwmckinney@gmail.com	|

Scenario Outline: 3.Provide data to step definition as Examples table
	Given I pass <Name>, <Age>, <Phone> and <Email> to the step definition
	Examples: 
	| Name           | Age | Phone        | Email						|
	| Steve McKinney | 54  | 07807 359194 | stevejmckinney@gmail.com	|
	| John McKinney	 | 52  | 07807 123456 | johnamckinney@gmail.com		|
	| Dick McKinney	 | 48  | 07807 654321 | richardwmckinney@gmail.com	|
