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
using static Mars_QA.Pages.CommonMethods;
//#nullable disable

namespace Mars_QA.Utilities
{
    [Binding]
    public class CommonDriver : Driver
    {
      [BeforeTestRun]
      public static void BeforeTestRun()
      {
         ExtentReports();
      }

      [BeforeFeature]
      public static void BeforeFeature(FeatureContext context)
      {
           test = Extent.StartTest(context.FeatureInfo.Title);
      }


      [BeforeScenario]
      public void Setup()
      {
           //launch the browser
           Initialize();
           Thread.Sleep(3000);

            //call the SignIn class
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps();

            //LoginPage.LoginSteps();
      }

      [AfterScenario]
      public void TearDown()
      {

          //Screenshot
          string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
          test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            //Close the browser
            Close();

            //end test. (Reports)
            CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();
      }

    }
}

//    [BeforeTestRun]

//    public static void BeforeTestRun()
//    {
//        ExtentReports();
//    }


//    [BeforeFeature]

//    public static void BeforeFeature(FeatureContext contex)
//    {
//        test = Extent.StartTest(contex.FeatureInfo.Title);

//    }