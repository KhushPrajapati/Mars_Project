using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Mars_QA.Pages
{
    public class Education
    {
        public void AddEducation(IWebDriver driver)
        {
            // Select Education tab
            IWebElement selectEducationTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            selectEducationTab.Click();

            // Click on Add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewButton.Click();

            // Identify University name textbox and input name
            IWebElement universityTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universityTextbox.SendKeys("GTU");

            // Identify Country dropdown and select name
            IWebElement countryDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            countryDropdown.Click();

            // Identify Title dropdown and select title
            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[8]"));
            titleDropdown.Click();

            // Identify Degree textbox and input degree
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeTextbox.SendKeys("Masters");

            // Identify Year dropdown and select year
            IWebElement yearDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[10]"));
            yearDropdown.Click();

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addButton.Click();
        }

        public string GetUniversity(IWebDriver driver)
        {
            IWebElement actualUniversity = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualUniversity.Text;
        }
    }
}
