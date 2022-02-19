using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_QA.Utilities;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
#nullable disable

namespace Mars_QA.Pages
{
    public class CommonMethods
    {
        //Screenshots
        #region screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantUtils.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }

            //internal static string SaveScreenshot(object driver, string v)
            //{
            //    throw new NotImplementedException();
            //}
        }
        #endregion

        //ExtentReports
        #region reports

        public static ExtentTest test;
        public static ExtentReports Extent;

        public static void ExtentReports()
        {
            Extent = new ExtentReports(ConstantUtils.ReportsPath, true, DisplayOrder.NewestFirst);
            Extent.LoadConfig(ConstantUtils.ReportXMLPath);
        }

        #endregion
    }
}

