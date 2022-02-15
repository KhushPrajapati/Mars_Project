using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_QA.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // Open Chrome Browser
            driver.Manage().Window.Maximize();

            // Launch the Portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            // Click on Sign in Button
            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signinButton.Click();

            try
            {
                // Identify username textbox and enter valid username
                IWebElement emailAddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailAddressTextbox.SendKeys("khush123@gmail.com");

                // Identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("Khush@123");

                // Click on Login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Mars profile portal login page did not launch", ex.Message);
            }
        }
    }
}

