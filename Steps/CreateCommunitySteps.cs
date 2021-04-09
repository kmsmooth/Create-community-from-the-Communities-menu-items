using AutomationTest.Hooks;
using AutomationTest.PageObjects;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationTest.Steps
{
    [Binding]
    public class _199CreateCommunityFromTheCommunitiesMenuItemsSteps
    {
        public IWebDriver driver = WebHook.driver;
        CreateCommunityPage createCommunityPage = new CreateCommunityPage();

        [Given(@"I navigate to www\.giftrete\.com")]
        public void GivenINavigateToWww_Giftrete_Com()
        {
            driver.Navigate().GoToUrl(@"https://www.qa2020.giftrete.com/");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I click on sign in")]
        public void GivenIClickOnSignIn()
        {
            createCommunityPage.ClickSignIn();
        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            Thread.Sleep(2000);
            createCommunityPage.EnterEmail();
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            createCommunityPage.EnterPassword();
        }
        
        [Given(@"I click on login")]
        public void GivenIClickOnLogin()
        {
            createCommunityPage.ClickLogin();
        }
        
        [Given(@"I click communities from the menu items \(on left side of the page\)\.")]
        public void GivenIClickCommunitiesFromTheMenuItemsOnLeftSideOfThePage_()
        {
            createCommunityPage.CommunityMenu();
        }
        
        [Given(@"user click create community")]
        public void GivenUserClickCreateCommunity()
        {
            createCommunityPage.CreateCommunityHeaderButton();
        }
        
        [Given(@"I enter community name")]
        public void GivenIEnterCommunityName()
        {
            createCommunityPage.CommunityName();
        }
        
        [Given(@"I enter community handle")]
        public void GivenIEnterCommunityHandle()
        {
            createCommunityPage.CommunityHandle();
        }
        
        [Given(@"I enter my location address")]
        public void GivenIEnterMyLocationAddress()
        {
            createCommunityPage.LocationAddress();
        }
        
        [Given(@"I select category \(from the drop down\)")]
        public void GivenISelectCategoryFromTheDropDown()
        {
            createCommunityPage.SelectCategory();
        }
        
        [Given(@"I choose file \(upload file\)")]
        public void GivenIChooseFileUploadFile()
        {
           createCommunityPage.UploadFile();
            
        }
        
        [Given(@"I select membership type by ticking the box \(Private or Public or Closed\)")]
        public void GivenISelectMembershipTypeByTickingTheBoxPrivateOrPublicOrClosed()
        {
            createCommunityPage.MembershipType();
        }
        
        [Given(@"I enter the link to the community website")]
        public void GivenIEnterTheLinkToTheCommunityWebsite()
        {
            createCommunityPage.CommunityWebsite();
        }

        [Given(@"I leave community description blank")]
        public void GivenILeaveCommunityDescriptionBlank()
        {
            createCommunityPage.CommunityDescription();
        }


        [When(@"I click create community")]
        public void WhenIClickCreateCommunity()
        {
            //createCommunityPage.CreateCommunityButton();
        }

        [Then(@"a community should be not created successfully")]
        public void ThenACommunityShouldBeNotCreatedSuccessfully()
        {
            
        }

    }
}
