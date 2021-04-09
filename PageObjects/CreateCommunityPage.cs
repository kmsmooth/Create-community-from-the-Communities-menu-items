using AutomationTest.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationTest.PageObjects
{
    class CreateCommunityPage
    {
        public IWebDriver driver;
        public CreateCommunityPage()
        {
            driver = WebHook.driver;
        }

        private By signIn = By.XPath("//*[contains(text(),'Sign In')]");
        private By enterEmailAddress = By.Id("user_email");
        private By enterPassword = By.Id("user_password");
        private By login = By.Id("btn_signin");
        private By communityMenu = By.XPath("//*[@id='navigation-widget-small']/ul/li[2]/a");
        private By createCommunityHeaderButton = By.XPath("/html/body/div[2]/section/div[1]/div[2]/a/p");
        private By communityName = By.Id("name");
        private By communityHandle = By.Id("cleanname");
        private By locationAddress = By.Id("autocomplete");
        private By selectCategory = By.Id("group_type_id");
        private By uploadFile = By.Id("files");
        private By membershipType = By.CssSelector(".accordion-trigger-linked");
        private By communityWebsite = By.Id("website");
        private By communityDescription = By.ClassName("cke_editable cke_editable_themed cke_contents_ltr");
        private By createCommunityButton = By.Id("btn_create");
       

        public void ClickSignIn()
        {
            driver.FindElement(signIn).Click();
        }
        public void EnterEmail()
        {
           driver.FindElement(enterEmailAddress).Click();
           driver.FindElement(enterEmailAddress).Clear();
           driver.FindElement(enterEmailAddress).SendKeys("testingtest101@mail.com"); 
        }
        public void EnterPassword()
        {
            driver.FindElement(enterPassword).Clear();
            driver.FindElement(enterPassword).Click();
            driver.FindElement(enterPassword).SendKeys("Fulham11.");
        }

        public void ClickLogin()
        {
            driver.FindElement(login).Click();
        }

        public void CommunityMenu()
        {
            Thread.Sleep(1000);
            driver.FindElement(communityMenu).Click();
        }

        public void CreateCommunityHeaderButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(createCommunityHeaderButton).Click();
        }

        public void CommunityName()
        {
            driver.FindElement(communityName).SendKeys("ArsenalFanBoy");
        }

        public void CommunityHandle()
        {
            driver.FindElement(communityHandle).SendKeys("ArsenalFanClub");
        }

        public void LocationAddress()
        {
            driver.FindElement(locationAddress).SendKeys("London");
        }

        public void SelectCategory()
        {
            driver.FindElement(selectCategory).SendKeys("sport");
        }

        public void UploadFile()
        {
            driver.FindElement(uploadFile).SendKeys(@"C:\Users\Tosin\OneDrive\Pictures\arsenal.jpg");
        }

        public void MembershipType()
        {
            driver.FindElement(membershipType).Click();
        }

        public void CommunityWebsite()
        {
            driver.FindElement(communityWebsite).SendKeys("www.arsenal.com");
        }

        public void CommunityDescription()
        {
            driver.FindElement(communityDescription).Click();
            driver.FindElement(communityDescription).SendKeys("");
        }

        public void CreateCommunityButton()
        {
            //driver.FindElement(createCommunityButton).Click();
        }
        
       




























    }





}
