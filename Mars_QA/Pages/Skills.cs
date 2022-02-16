using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Mars_QA.Pages
{
    public class Skills
    {
        public void AddSkills(IWebDriver driver, string skill, string level)
        {
            Thread.Sleep(5000);

            // Click on Skill tab
            IWebElement skillTab = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
            skillTab.Click();

            Thread.Sleep(3000);

            // Click on Addnew button
            IWebElement AddNewSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewSkill.Click();

            // Identify Skill textbox and input skill
            IWebElement SkillTextBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            SkillTextBox.SendKeys(skill);
            Thread.Sleep(3000);

            // Choose Level of skill from dropdown list
            IWebElement ChooseSkillLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
            ChooseSkillLevel.Click();

            var selectElement = new SelectElement(ChooseSkillLevel);
            selectElement.SelectByValue(level);
            Thread.Sleep(3000);

            //IWebElement SelectSkilllevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            //SelectSkilllevel.Click();

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            addButton.Click();
            Thread.Sleep(5000);
        }
        public string GetSkill(IWebDriver driver, string skill)
        {
            IWebElement actualSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualSkill.Text;
        }

        public string GetSkillLevel(IWebDriver driver, string level)
        {
            IWebElement actualSkillLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualSkillLevel.Text;

        }
    }
}