Feature: Skills
	As a seller
	I would like to add,edit and delete my skills

@Skills
Scenario: [Add Seller skill detail]
	Given [I Logged into Mars portal Skill page]
	When [I try to add new Skill on profile page]
	Then [Seller should add Skill successfully]
