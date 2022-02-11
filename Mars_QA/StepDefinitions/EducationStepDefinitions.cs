using System;
using Mars_QA.Pages;
using Mars_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_QA.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {
        LoginPage loginpageobj = new LoginPage();
        Education educationobj = new Education();

        [Given(@"\[I Logged into Mars portal Education page]")]
        public void GivenILoggedIntoMarsPortalEducationPage()
        {
            driver = new ChromeDriver();

            loginpageobj.LoginSteps(driver);
        }

        [When(@"\[I try to add new Education on profile page]")]
        public void WhenITryToAddNewEducationOnProfilePage()
        {
            educationobj.AddEducation(driver);
        }

        [Then(@"\[Seller should add Education successfully]")]
        public void ThenSellerShouldAddEducationSuccessfully()
        {
            string actualUniversity = educationobj.GetUniversity(driver);

            Assert.That(actualUniversity == "GTU", "Actual University and Expected University do not match.");
        }
    }
}
