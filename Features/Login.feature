Feature: my Login 
As a user I shold be able to login successfully

@Smoke
Scenario: I login using valid credientials
Given I am on homepage
When I enter user name "standard_user"
And I enter password "secret_sauce"
And I click on login button
Then I should login successfully

@Sanity
Scenario: I login using invalid credientials
Given I am on homepage
When I enter user name "standard_user1" now
And I enter password "secret_sauce"
And I click on login button
Then I should not be login successfully