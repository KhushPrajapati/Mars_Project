using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_QA.Pages
{
    public class Languages
    {
        public void AddLanguage(IWebDriver driver)
        {
            // Select Language tab
            IWebElement selectLanguageTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            selectLanguageTab.Click();

            // Click on addnew button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);

            // Identify add language textbox and input language
            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguageTextbox.Click();

            IWebElement inputLanguageTextbox = driver.FindElement(By.Name("name"));
            inputLanguageTextbox.SendKeys("English");

            // Identify level dropdown and select language level
            IWebElement langLevel = driver.FindElement(By.Name("level"));
            langLevel.Click();

            IWebElement selectLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            selectLevel.Click();
            //new SelectElement(driver.FindElement(By.Name("level"))).SelectByText("Conversational");

            // Click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account - profile - section'']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

            // Click on addnew button for 2nd language
            IWebElement addNewButton1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton1.Click();
            Thread.Sleep(2000);

            // Identify add language textbox and input language
            IWebElement addLanguageTextbox1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguageTextbox1.Click();

            IWebElement inputLanguageTextbox1 = driver.FindElement(By.Name("name"));
            inputLanguageTextbox1.SendKeys("Gujarati");

            // Identify level dropdown and select language level
            IWebElement langLevel1 = driver.FindElement(By.Name("level"));
            langLevel.Click();

            new SelectElement(driver.FindElement(By.Name("level"))).SelectByText("Native/Bilingual");

            // Click on add button
            IWebElement addButton1 = driver.FindElement(By.XPath("//*[@id='account - profile - section'']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton1.Click();
        }

        public string GetLanguage(IWebDriver driver)
        {
            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualLanguage.Text;
        }

        public string GetLevel(IWebDriver driver)
        {
            IWebElement actualLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualLevel.Text;
        }

        public void EditLanguage(IWebDriver driver)
        {
            // Click on Edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            editButton.Click();


        }
    }
}
