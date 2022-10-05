Feature: ContacUS
	As user
	I want to be able to use Contact Us form
	so I can contact customer service

@mytag @smoke
Scenario: User can contact customer service
	Given user opens contact us page
	When user fills in all required fields with 'Webmaster' heading and 'QA Kurs' message
	And user submits the form
	Then message 'Your message has been successfully sent to our team.' is presented to the user