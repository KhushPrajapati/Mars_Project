using System;
using Mars_QA.Pages;
using Mars_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_QA.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver
    {
        LoginPage loginpageobj = new LoginPage();
        Languages languageobj = new Languages();

        [Given(@"\[I Logged into Mars portal Language page]")]
        public void GivenILoggedIntoMarsPortalLanguagePage()
        {
            //driver = new ChromeDriver();
            loginpageobj.LoginSteps();
        }

        [When(@"\[I try to add new '([^']*)' and '([^']*)' on profile page]")]
        public void WhenITryToAddNewAndOnProfilePage(string p0, string p1)
        {
            languageobj.AddLanguage(driver, p0, p1);
        }

        [Then(@"\[The record should have an updated for '([^']*)' and '([^']*)']")]
        public void ThenTheRecordShouldHaveAnUpdatedForAnd(string p0, string p1)
        {
            string addedLanguage = languageobj.GetLanguage(driver, p0);
            //string addedLanguage1 = languageobj.GetLanguage(driver, p0);
            string addedLevel = languageobj.GetLevel(driver, p1);
            //string addedLevel1 = languageobj.GetLevel(driver, p1);

            Assert.That(addedLanguage == p0, "Added Language and Expected Language do not match");
            Assert.That(addedLevel == p1, "Added Level and Expected Level do not match");
            //Assert.That(addedLanguage1 == p0, "Added Language and Expected Language do not match");
            //Assert.That(addedLevel1 == p1, "Added Level and Expected Level do not match");

        }

    }
}