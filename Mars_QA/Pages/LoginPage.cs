using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mars_QA.Helper;
#nullable disable

namespace Mars_QA.Pages
{
    public class LoginPage
    {
        public void LoginSteps()
        {
            Driver.NavigateUrl();
            Thread.Sleep(1000);

            // Open Chrome Browser
            Driver.driver.Manage().Window.Maximize();

            // Launch the Portal
            Driver.driver.Navigate().GoToUrl("http://localhost:5000/Home");

            // Click on Sign in Button
            IWebElement signinButton = Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signinButton.Click();

            try
            {
                // Identify username textbox and enter valid username
                IWebElement emailAddressTextbox = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailAddressTextbox.SendKeys("khush123@gmail.com");

                // Identify password textbox and enter valid password
                IWebElement passwordTextbox = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("Khush@123");

                // Click on Login button
                IWebElement loginButton = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Mars profile portal login page did not launch", ex.Message);
            }

            //Driver.driver.FindElement(By.XPath("//a[contains(.,'Sign In')]")).Click();
            ////Enter Username
            //Driver.driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("khush123@gmail.com");
            ////Enter password
            //Driver.driver.FindElement(By.XPath("//input[contains(@name,'password')]")).SendKeys("Khush@123");
            //Thread.Sleep(1000);
            ////Click on Login Button
            //Driver.driver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();
            ////button[contains(.,'Sign Out')]
            ////Validate if user logged in or not
            //IWebElement loggedin = Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span"));
            //Assert.AreEqual(loggedin.Text, "Hi KhushP");
            ////open web driver
        }
    }
}

