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
    public class Languages
    {
        public void AddLanguage(IWebDriver driver, string language, string level)
        {
            Thread.Sleep(3000);

            // Click on addnew button
            IWebElement addNewButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            addNewButton.Click();
            Thread.Sleep(3000);
            //Wait.WaitTobeClickable(driver, "XPath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 3);

            IWebElement LanguageTextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            LanguageTextbox.SendKeys(language);

            // Identify level dropdown and select language level
            IWebElement chooseLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
            chooseLevel.Click();

            var SelectElement = new SelectElement(chooseLevel);
            SelectElement.SelectByValue(level);

            //new SelectElement(driver.FindElement(By.Name("level"))).SelectByText("Conversational");

            // Click on add button
            IWebElement addButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
            addButton.Click();
            Thread.Sleep(3000);
        }

        public string GetLanguage(IWebDriver driver, string language)
        {
            IWebElement actualLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualLanguage.Text;

            //IWebElement actualLanguage1 = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td:nth-child(1)"));
            //return actualLanguage1.Text;
        }

        public string GetLevel(IWebDriver driver, string level)
        {
            IWebElement actualLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualLevel.Text;

            //IWebElement actualLevel1 = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td:nth-child(2)"));
            //return actualLevel1.Text;
        }
        //public void EditLanguage(IWebDriver driver)
        //{
        //    // Click on Edit button
        //    IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
        //    editButton.Click();
        //}
    }
}