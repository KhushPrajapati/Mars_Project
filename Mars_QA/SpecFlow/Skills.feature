Feature: Skills
	As a seller
	I would like to add,edit and delete my skills

@Skills
Scenario Outline: [Add Seller skill detail]
	Given [I Logged into Mars portal Skill page]
	When [I add new '<Skill>' and '<level>' on profile page]
	Then [Seller should add '<Skill>' and '<level>' successfully]

Examples: 
	| Skill        | level    |
	| Test Analyst | Beginner |
