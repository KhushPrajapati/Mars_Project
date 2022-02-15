using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_QA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
#nullable disable

namespace Mars_QA.Utilities
{
    [TestFixture]
    [Parallelizable]
    public class CommonDriver
    {
        // Initialize the Browser
        public IWebDriver driver;

        [OneTimeSetUp]
        //[BeforeScenario]
        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://192.168.99.100:5000");

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        //[AfterTestRun]
        [OneTimeTearDown]

        //[AfterScenario]
        public void CloseTestRun()
        {
            // close the window and release the memory
            //driver.Quit();
            driver.Dispose();
        }
    }
}
