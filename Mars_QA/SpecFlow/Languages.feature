Feature: Languages
	As a seller
	I would like to add,edit and delete my language

@Languages
Scenario Outline: [Add Seller language detail]
	Given [I Logged into Mars portal Language page]
	When [I try to add new Language on profile page]
	Then [The record should have an updated]

#Examples: 
#	| Language | Level            |
#	| English  | Conversational   |
#	| Hindi    | Native/Bilingual |
