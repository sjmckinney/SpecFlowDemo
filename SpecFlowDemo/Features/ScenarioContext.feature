Feature: Demo use of ScenarioContext to store simple and complex data types
	First scenario demonstrates the use of ScenarioContext to store and retrieve simple data as key pair
	Second scenario uses additional ScenarioContext methods Add and Get<> to store and retrieve more complex types

@ScenarioContext @SimpleType
Scenario: Store simple data type in one step and dsiplay it in other
	Given I pass this value MyStoredValue in this step
	Then Display stored value in this step

@ScenarioContext @ComplexType
Scenario: Store complex data type in one step and display it in other
	Given I assign complex data type in this step
	Then Display stored values in this step

@ScenarioContext @ScenarioInfo @ScenarioBlock
Scenario: ScenarioContext also has other properties like this title
	Given this is value of the current ScenarioInfo 
	And this is value of the current ScenarioBlock
