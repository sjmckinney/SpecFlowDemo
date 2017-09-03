Feature: Dynamically create objects from table data rather than based on POCO
	Would be tiresome to create POCOs matching table columns for multiple tests
	Dynamic creation using Dynamic.Assist extension can reduce need to do this

@mytag
Scenario: Pass a table in the step
	Given Pass a multi-row table to the step and display contents
	| Name           | Capital    | Population | Hemisphere |
	| United Kingdom | London     | 64430428   | North      |
	| United states  | Washington | 323995528  | North      |
	| China          | Beijing    | 1373541278 | North      |
	| Australia      | Canberra   | 22992654   | South      |
