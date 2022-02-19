Feature: Education

As a seller
	I would like to add,edit and delete my education

@Education
Scenario Outline: [Add Seller Education detail]
	Given [I Logged into Mars portal Education page]
	When [I try to add new '<Country>','<University>','<Title>','<Degree>'and'<GraduationYear>' on profile page]
	Then [Seller should add '<Country>','<University>','<Title>','<Degree>'and'<GraduationYear>' successfully]
Examples: 
	| Country | University | Title  | Degree  | GraduationYear |
	| India   | GTU        | M.Tech | Masters | 2014           |