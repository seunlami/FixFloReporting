Feature: FaultReport
	Reporting a water leak at an address

@mytag
Scenario: Water leak issue
	Given the user navigates to website "https://plus.test.fixflo.com/"
	And user clicks on water and leaks
	And user clicks on leak
	And user clicks on Water leak within property
	And user clicks on continue
	And user selects bowl inside the container text box
	And user selects minutes insde the how often text box
	And user selects leak frequency in text box
	And user enters fault details "Seun has a leaky roof"
	And user clicks on Next
	And user clicks on second Next button
	And user enters the postcode "RM9 6DB"
	And user clicks search button
	And user selects the address
	And user clicks the next button
	And user enters Title "Mr"
	And user enters First name "Seun"
	And user enters Surname "Odunlami"
	And user enters Email "seunlami@yahoo.com"
	And user enters phone number "07930322233"
	When user clicks the next button
	Then the submit issue button should be displayed