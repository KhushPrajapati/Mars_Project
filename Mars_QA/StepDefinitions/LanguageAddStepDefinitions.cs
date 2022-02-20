using System;
using Mars_QA.Helper;
using Mars_QA.Pages;
using Mars_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using static Mars_QA.Helper.CommonMethods;
#nullable disable

namespace Mars_QA.StepDefinitions
{
    [Binding]
    public class LanguageAddStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        Languages langPageObj = new Languages();

        [Given(@"I lodged into Mars language portal successfully")]
        public void GivenILodgedIntoMarsLanguagePortalSuccessfully()
        {
            //driver = new ChromeDriver();

            loginPageObj.LoginSteps();
        }

        [When(@"I add '([^']*)' and '([^']*)' details")]
        public void WhenIAddAndDetails(string p0, string p1)
        {
            langPageObj.AddLanguage(driver,p0,p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be able to see on Language profile  page")]
        public void ThenAndShouldBeAbleToSeeOnLanguageProfilePage(string p0, string p1)
        {
            string actualLanguage = langPageObj.GetLanguage(driver, p0);
            string actualLevel = langPageObj.GetLevel(driver, p1);

            Assert.That(actualLanguage == p0, "Actual Language and Expected Language do not match.");
            Assert.That(actualLevel == p1, "Actual Level and Expected Level do not match.");

            if (actualLanguage == p0 && actualLevel == p1)
            {
                CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed. Language added");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language Added");
                Assert.IsTrue(true);
            }
        }
    }
}
