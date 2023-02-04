Feature: Test1CetvrtiZadatak

A short summary of the feature

@tag1
Scenario: Login/Logout Saucedemo
	Given Navigate to Saucedemo Site
	When Enter username
	And Enter password
	And Click on Login button 
	Then Browser should open Home page
	When Click on Menu button 
	And Click on About button 
	Then Browser should open About page
	Then Navigate back 
	And Click on Menu button
	And Click on Logout button 
	Then Browser should close 
