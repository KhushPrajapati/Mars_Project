using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_QA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_QA.Pages
{
    public class Education
    {
        public void AddEducation(IWebDriver driver, string country, string university, string title, string degree, string graduationyear)
        {
            Thread.Sleep(6000);
            //Wait.WaitTobeVisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)", 4);

            // Select Education tab
            IWebElement selectEducationTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)"));
            selectEducationTab.Click();
            Thread.Sleep(3000);

            // Click on Add new button
            IWebElement addNewButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            addNewButton.Click();

            // Identify University name textbox and input name
            IWebElement universityTextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.ten.wide.field > input[type=text]"));
            universityTextbox.SendKeys(university);

            // Identify Country dropdown and select name
            IWebElement countryDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.six.wide.field > select"));
            countryDropdown.Click();

            var selectElement = new SelectElement(countryDropdown);
            selectElement.SelectByValue(country);
            Thread.Sleep(3000);

            // Identify Title dropdown and select title
            IWebElement titleDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select"));
            titleDropdown.Click();

            var selectElement1 = new SelectElement(titleDropdown);
            selectElement1.SelectByValue(title);

            // Identify Degree textbox and input degree
            IWebElement degreeTextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(2) > input[type=text]"));
            degreeTextbox.SendKeys(degree);

            // Identify Year dropdown and select year
            IWebElement yearDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.four.wide.field > select"));
            yearDropdown.Click();

            var selectElement2 = new SelectElement(yearDropdown);
            selectElement2.SelectByValue(graduationyear);

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(3) > div > input.ui.teal.button"));
            addButton.Click();
            Thread.Sleep(4000);
        }

        public string GetCountry(IWebDriver driver, string country)
        {
            IWebElement actualCountry = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualCountry.Text;
        }
        public string GetUniversity(IWebDriver driver, string university)
        {
            IWebElement actualUniversity = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualUniversity.Text;
        }
        public string GetTitle(IWebDriver driver, string title)
        {
            IWebElement actualTitle = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(3)"));
            return actualTitle.Text;
        }
        public string GetDegree(IWebDriver driver, string degree)
        {
            IWebElement actualDegree = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(4)"));
            return actualDegree.Text;
        }
        public string GetGraduationYear(IWebDriver driver, string graduationyear)
        {
            IWebElement actualGraduationYear = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(5)"));
            return actualGraduationYear.Text;
        }
    }
}