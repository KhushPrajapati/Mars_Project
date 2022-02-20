using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA.Helper
{
    public class ConstantUtils
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        public static string CurrantPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        //ScreenshotPath
        public static string ScreenshotPath = CurrantPath + @"TestReports\Screenshots";

        //ExtentReportsPath
        public static string ReportsPath = CurrantPath + @"TestReports\Test.html";

        //ReportXML Path
        public static string ReportXMLPath = CurrantPath + @"TestReports\ReportXMLFile.xml";
    }
}
