Feature: Certifications

As a seller
	I would like to add,edit and delete my certifications

@Certifications
Scenario Outline: [Add Seller Certifications detail]
	Given [I Logged into Mars portal Certifications page]
	When [I try to add new '<certificate>','<from>' and '<year>' on profile page]
	Then [Seller should add '<certificate>','<from>' and '<year>' successfully]

Examples: 
	| certificate      | from             | year |
	| Software Testing | Industry Connect | 2022 |