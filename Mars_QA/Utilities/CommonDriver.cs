using Mars_QA.Helper;
using Mars_QA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static Mars_QA.Helper.CommonMethods;
#nullable disable

namespace Mars_QA.Utilities
{
    //[TestFixture]
    //[Parallelizable]
    [Binding]
    public class CommonDriver : Driver
    {

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReports();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext contex)
        {
            test = Extent.StartTest(contex.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void SetUp()
        {
            Initialize();
            Thread.Sleep(2000);

            //ExcellibHelper.PopulateInCollection()

           // LoginPage loginPageObj = new LoginPage();
           // loginPageObj.LoginSteps();
            //Mars_QA.Pages.LoginPage.LoginSteps(); ;

            Console.WriteLine("Login Success");
        }

        //[AfterScenario]
        [Test]
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            CommonMethods.Extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();

            //Close the browser
            driver.Close();

            Console.WriteLine("Closed the browser");
        }
        //public IWebDriver driver;

        //[OneTimeSetUp]
        //public void LoginFunction()
        //{
        //    driver = new ChromeDriver();

        //    // Login page object initialization and definition
        //    LoginPage loginPageObj = new LoginPage();
        //    loginPageObj.LoginSteps(driver);
        //}

        //[OneTimeTearDown]
        //public void CloseTestRun()
        //{
        //    driver.Quit();
        //}
    }
}