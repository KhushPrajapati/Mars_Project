using System;
using Mars_QA.Pages;
using Mars_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_QA.StepDefinitions
{
    [Binding]
    public class CertificationsStepDefinitions : CommonDriver
    {
        LoginPage loginpageobj = new LoginPage();
        Certifications certificateobj = new Certifications();

        [Given(@"\[I Logged into Mars portal Certifications page]")]
        public void GivenILoggedIntoMarsPortalCertificationsPage()
        {
            driver = new ChromeDriver();

            loginpageobj.LoginSteps(driver);
        }

        [When(@"\[I try to add new certifications on profile page]")]
        public void WhenITryToAddNewCertificationsOnProfilePage()
        {
            certificateobj.AddCertifications(driver);
        }

        [Then(@"\[Seller should add certifications successfully]")]
        public void ThenSellerShouldAddCertificationsSuccessfully()
        {
            string actualCertificate = certificateobj.GetCertificate(driver);
            string actualFrom = certificateobj.GetFrom(driver);
            string actualYear = certificateobj.GetYear(driver);

            Assert.That(actualCertificate == "Software Testing", "Actual Certificate and Expected Certificate do not match.");
            Assert.That(actualFrom == "Industry Connect", "Actual From and Expected From do not match.");
            Assert.That(actualYear == "2022", "Actual Year and Expected Year do not match.");
        }
    }
}
