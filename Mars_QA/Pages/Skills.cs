using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Mars_QA.Pages
{
    public class Skills
    {
        public void AddSkills(IWebDriver driver)
        {
            // Select Skill tab
            IWebElement selectSkillTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            selectSkillTab.Click();

            // Click on Add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            // Identify skill textbox and input skill
            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkillTextbox.SendKeys("Automation Testing");

            // Identify level dropdown and select level
            IWebElement addLevelDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            addLevelDropdown.Click();

            IWebElement selectLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            selectLevel.Click();

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();
        }

        public string GetSkill(IWebDriver driver)
        {
            IWebElement actualSkill = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualSkill.Text;
        }
    }
}
