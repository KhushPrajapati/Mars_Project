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
            //driver = new ChromeDriver();

            loginpageobj.LoginSteps();
        }

        [When(@"\[I try to add new '([^']*)','([^']*)' and '([^']*)' on profile page]")]
        public void WhenITryToAddNewAndOnProfilePage(string p0, string p1, string p2)
        {
            certificateobj.AddCertifications(driver, p0, p1, p2);
        }

        [Then(@"\[Seller should add '([^']*)','([^']*)' and '([^']*)' successfully]")]
        public void ThenSellerShouldAddAndSuccessfully(string p0, string p1, string p2)
        {
            string actualCertificate = certificateobj.GetCertificate(driver, p0);
            string actualFrom = certificateobj.GetFrom(driver, p1);
            string actualYear = certificateobj.GetYear(driver, p2);

            Assert.That(actualCertificate == p0, "Actual Certificate and Expected Certificate do not match.");
            Assert.That(actualFrom == p1, "Actual From and Expected From do not match.");
            Assert.That(actualYear == p2, "Actual Year and Expected Year do not match.");
        }
    }
}