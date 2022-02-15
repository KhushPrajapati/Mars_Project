using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Mars_QA.Pages
{
    public class Certifications
    {
        public void AddCertifications(IWebDriver driver)
        {
            Thread.Sleep(6000);

            // Select Certification tab
            IWebElement selectCertificationsTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)"));
            selectCertificationsTab.Click();
            Thread.Sleep(3000);

            // Click on Add new button
            IWebElement addNewButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            addNewButton.Click();

            // Identify Certificate textbox and input name
            IWebElement certificateNameTextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div > input"));
            certificateNameTextbox.SendKeys("Software Testing");
            Thread.Sleep(3000);

            // Identify Certified from textbox and input name
            IWebElement fromTextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.eight.wide.field > input"));
            fromTextbox.SendKeys("Industry Connect");

            // Select Year from dropdown
            IWebElement yearDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select"));
            yearDropdown.Click();

            var SelectElement = new SelectElement(yearDropdown);
            SelectElement.SelectByValue("2022");
            Thread.Sleep(3000);

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button"));
            addButton.Click();
            Thread.Sleep(5000);
        }

        public string GetCertificate(IWebDriver driver)
        {
            IWebElement actualCertificate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualCertificate.Text;
        }
        public string GetFrom(IWebDriver driver)
        {
            IWebElement actualFrom = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualFrom.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            IWebElement actualYear = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(3)"));
            return actualYear.Text;
        }
    }
}
