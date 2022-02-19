using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA.Pages
{
    public class ConstantUtils
    {
        //Base Url
        public static string Url = "http://localhost:5000/";

        public static string Currentpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        //ScreenshotPath
        public static string ScreenshotPath = Currentpath + @"Mars_QA\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = Currentpath + @"Mars_QA\TestReports\TestRunReport.html";

        //ReportXML Path
        public static string ReportXMLPath = Currentpath + @"Mars_QA\TestReports\ExtentReport_config.xml";
    }
}
