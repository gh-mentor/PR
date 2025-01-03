# This is a SpecFlow feature file that calculates the payment for an hourly employee
# and shows the details of the employee

# This feature 'HourlyEmployee' calculates the payment for an hourly employee and shows the details of the employee
Feature: HourlyEmployee	
	In order to calculate the payment for an hourly employee
	As a payroll administrator
	I want to calculate the payment for an hourly employee and show the details of the employee

# This scenario calculates the payment for an hourly employee
Scenario: Calculate payment for an hourly employee
	Given the hourly rate is $10
	And the number of hours worked is 40
	When the payment is calculated
	Then the payment should be $400
	And the employee details should be displayed











