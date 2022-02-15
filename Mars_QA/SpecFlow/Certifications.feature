Feature: Certifications

As a seller
	I would like to add,edit and delete my certifications

@Certifications
Scenario: [Add Seller Certifications detail]
	Given [I Logged into Mars portal Certifications page]
	When [I try to add new certifications on profile page]
	Then [Seller should add certifications successfully]
