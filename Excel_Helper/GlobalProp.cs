using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excel_Helper
{
    class GlobalProp
    {
        public static string CurrentData { get; set; } // Выбранные данные на форме выбора
        public static string FilePath { get; set; } // путь к файлу
        public static string DirPath { get; set; } // директория
        public static ExcelPackage ExPack { get; set; } // развертка Excel
        public static ExcelWorksheets ListSheet { get; set; } // листы в файле
        public static ExcelWorksheet WSheet { get; set; } // активный лист
        public static string HatRange { get; set; } // диапазон шапки
        public static List<string> ListofFiles = new List<string>(); // список файлов в директории

    }
}
