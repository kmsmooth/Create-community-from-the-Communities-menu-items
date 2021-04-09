Feature: 199 Create community from the Communities menu items with
	AS a user on Giftrete website (www.giftrete.com)
    I want to create a community
    So that members can exchange gift items

@CreateCommunity
	Scenario: Create community from the Communities menu items (by leaving community description blank)
	Given I navigate to www.giftrete.com
	And  I click on sign in
	And   I enter my email address
	And   I enter password
	And   I click on login
	And  I click communities from the menu items (on left side of the page).
	And  user click create community
	And  I enter community name
	And  I enter community handle
	And  I enter my location address
	And  I select category (from the drop down)
	And  I choose file (upload file)
	And  I select membership type by ticking the box (Private or Public or Closed)
	And  I enter the link to the community website
	And I leave community description blank
	When I click create community
	Then  a community should be not created successfully