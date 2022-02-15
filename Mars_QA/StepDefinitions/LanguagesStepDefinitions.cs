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
                driver = new ChromeDriver();
                loginpageobj.LoginSteps(driver);
            }

            [When(@"\[I try to add new Language on profile page]")]
            public void WhenITryToAddNewLanguageOnProfilePage()
            {
                languageobj.AddLanguage(driver);
            }

            [Then(@"\[The record should have an updated]")]
            public void ThenTheRecordShouldHaveAnUpdated()
            {
                string addedLanguage = languageobj.GetLanguage(driver);
                string addedLevel = languageobj.GetLevel(driver);

                Assert.That(addedLanguage == "English", "Added Language and Expected Language do not match");
                Assert.That(addedLevel == "Conversational", "Added Level and Expected Level do not match");

            }
        }
}
