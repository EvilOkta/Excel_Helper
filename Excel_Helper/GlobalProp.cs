using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excel_Helper
{
    class GlobalProp
    {
        public static string CurrentData { get; set; }
        public static string FilePath { get; set; }
        public static string DirPath { get; set; }
        public static ExcelPackage ExPack { get; set; }
        public static ExcelWorksheets ListSheet { get; set; }
        public static ExcelWorksheet WSheet { get; set; }
        public static string HatRange { get; set; }
        public static List<string> ListofFiles = new List<string>();

    }
}
