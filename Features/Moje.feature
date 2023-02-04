Feature: Moje

A short summary of the feature

@ExecuteAutomation
Scenario: Execute_Automation_Site_Login
	Given Navigate to Execute Automation page
	When Select title 
	And Enter initials
	And Enter first name
	And Enter middle name 
	And Click on Save button 
	Then Close browser  
