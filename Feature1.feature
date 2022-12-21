Feature: Feature1

Ecommerce home page

@smoke
Scenario: Home page
Given I Navigate to home page
Then Home page is displayed

@smoke
Scenario: Shop Page
Given I Navigate to home page
When I click on shop page
Then shop page is displayed

@smoke
Scenario: Slay the deal page
Given I Navigate to home page
When I Click on slay button 
Then Page is displayed




