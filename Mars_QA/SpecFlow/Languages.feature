Feature: Language add
As a seller
I want a feature to add my known languages 
So that
People seeking for some skill can look into my detail

@Languages
Scenario Outline: Add language description with valid details
    Given I lodged into Mars language portal successfully
   	When I add '<language>' and '<level>' details
	Then '<language>' and '<level>' should be able to see on Language profile  page

    Examples: 
	| language |   level          |
	| English  |   Conversational |