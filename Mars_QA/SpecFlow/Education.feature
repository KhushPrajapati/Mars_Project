Feature: Education

As a seller
	I would like to add,edit and delete my education

@Education
Scenario: [Add Seller Education detail]
	Given [I Logged into Mars portal Education page]
	When [I try to add new Education on profile page]
	Then [Seller should add Education successfully]
