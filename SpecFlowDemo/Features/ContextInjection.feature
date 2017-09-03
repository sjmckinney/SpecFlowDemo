Feature: ContextInjection is an alternate way that data can be shared between two binding classes
	Country objects are injected into the constructors for the ExtendSteps.cs and ContextInjection.cs classes
	These are assigned to the two binding classes field variable; Country country.
	The first step assigns the table fields to the ContextInjection.country fields
	The second step restrieves these populated fields from the ExtendedSteps.country instance

@context_injection
Scenario: Share data between two binding classes using Context Injection
	Given The country's details are passed in this step
	| Name           | Capital    | Population | Hemisphere |
	| Australia      | Canberra   | 22992654   | South      |
	Then I should be able to access them in this step
