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
            driver = new ChromeDriver();

            loginpageobj.LoginSteps(driver);
        }

        [When(@"\[I try to add new Skill on profile page]")]
        public void WhenITryToAddNewSkillOnProfilePage()
        {
            skillObj.AddSkills(driver);
        }

        [Then(@"\[Seller should add Skill successfully]")]
        public void ThenSellerShouldAddSkillSuccessfully()
        {
            string actualSkill = skillObj.GetSkill(driver);

            Assert.That(actualSkill == "Automation Testing", "Actual Skill and Expected Skill do not match.");
        }
    }
}
