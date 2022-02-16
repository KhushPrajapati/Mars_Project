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

        [When(@"\[I try to add new '([^']*)','([^']*)','([^']*)','([^']*)'and'([^']*)' on profile page]")]
        public void WhenITryToAddNewAndOnProfilePage(string p0, string p1, string p2, string p3, string p4)
        {
            educationobj.AddEducation(driver, p0,p1,p2,p3,p4);
        }

        [Then(@"\[Seller should add '([^']*)','([^']*)','([^']*)','([^']*)'and'([^']*)' successfully]")]
        public void ThenSellerShouldAddAndSuccessfully(string p0, string p1, string p2, string p3, string p4)
        {
            string actualCountry = educationobj.GetCountry(driver,p0);
            string actualUniversity = educationobj.GetUniversity(driver,p1);
            string actualTitle = educationobj.GetTitle(driver,p2);
            string actualDegree = educationobj.GetDegree(driver,p3);
            string actualGradYear = educationobj.GetGraduationYear(driver,p4);

            Assert.That(actualCountry == p0, "Actual Country and Expected Country do not match.");
            Assert.That(actualUniversity == p1, "Actual University and Expected University do not match.");
            Assert.That(actualTitle == p2, "Actual Title and Expected Title do not match.");
            Assert.That(actualDegree == p3, "Actual Degree and Expected Degree do not match.");
            Assert.That(actualGradYear == p4, "Actual Grad year and Expected Grad year do not match.");
        }
    }
}
