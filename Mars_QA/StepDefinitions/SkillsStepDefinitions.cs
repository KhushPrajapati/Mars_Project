using System;
using Mars_QA.Pages;
using Mars_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_QA.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : CommonDriver
    {
        LoginPage loginpageobj = new LoginPage();
        Skills skillObj = new Skills();

        [Given(@"\[I Logged into Mars portal Skill page]")]
        public void GivenILoggedIntoMarsPortalSkillPage()
        {
            //driver = new ChromeDriver();

            loginpageobj.LoginSteps();
        }

        [When(@"\[I add new '([^']*)' and '([^']*)' on profile page]")]
        public void WhenIAddNewAndOnProfilePage(string p0, string p1)
        {
            skillObj.AddSkills(driver, p0, p1);
        }

        [Then(@"\[Seller should add '([^']*)' and '([^']*)' successfully]")]
        public void ThenSellerShouldAddAndSuccessfully(string p0, string p1)
        {
            string actualSkill = skillObj.GetSkill(driver, p0);
            string actualSkillLevel = skillObj.GetSkillLevel(driver, p1);

            Assert.That(actualSkill == p0, "Actual Skill and Expected Skill do not match.");
            Assert.That(actualSkillLevel == p1, "Actual Skill level and Expected Skill level do not match.");
        }
    }
}