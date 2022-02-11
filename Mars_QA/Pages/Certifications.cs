using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Mars_QA.Pages
{
    public class Certifications
    {
        public void AddCertifications(IWebDriver driver)
        {
            // Select Certification tab
            IWebElement selectCertificationsTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            selectCertificationsTab.Click();

            // Click on Add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();

            // Identify Certificate textbox and input name
            IWebElement certificateNameTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateNameTextbox.SendKeys("Software Testing");

            // Identify Certified from textbox and input name
            IWebElement certifiedFromTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificateNameTextbox.SendKeys("Industry Connect");

            // Select Year from dropdown
            IWebElement yearDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            yearDropdown.Click();

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }

        public string GetCertificate(IWebDriver driver)
        {
            IWebElement actualCertificate = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return actualCertificate.Text;
        }
    }
}
