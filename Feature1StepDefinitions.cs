using OpenQA.Selenium;
using SpecFlowProject2.Drivers;
using SpecFlowProject2.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {

        BaseDriver Basedriver;
        HomePage home;

        [Given(@"I Navigate to home page")]
        public void GivenINavigateToHomePage()
        {
            Basedriver = new BaseDriver();
            Basedriver.Setup();
            Thread.Sleep(2000);
        }

        [Then(@"Home page is displayed")]
        public void ThenHomePageIsDisplayed()
        {
            Screenshot ss = ((ITakesScreenshot)Basedriver.driver).GetScreenshot();
            ss.SaveAsFile("Home.png", ScreenshotImageFormat.Png);

            Basedriver.closedriver();
        }

        [When(@"I click on shop page")]
        public void WhenIClickOnShopPage()
        {
            home = new HomePage(Basedriver.driver);
            home.shop.Click();
            Thread.Sleep(2000);
        }

        [Then(@"shop page is displayed")]
        public void ThenShopPageIsDisplayed()
        {
            Screenshot ss = ((ITakesScreenshot)Basedriver.driver).GetScreenshot();
            ss.SaveAsFile("Shop.png", ScreenshotImageFormat.Png);

            Basedriver.closedriver();
        }

        [When(@"I Click on slay button")]
        public void WhenIClickOnSlayButton()
        {
            home = new HomePage(Basedriver.driver);
            home.Slay.Click();
            
            Thread.Sleep(3000);
        }

        [Then(@"Page is displayed")]
        public void ThenPageIsDisplayed()
        {
            Screenshot ss = ((ITakesScreenshot)Basedriver.driver).GetScreenshot();
            ss.SaveAsFile("Slay.png", ScreenshotImageFormat.Png);

            Basedriver.closedriver();
        }
    }
}
