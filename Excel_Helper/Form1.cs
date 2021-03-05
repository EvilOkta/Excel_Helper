using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Excel_Helper.GlobalProp;
using static Excel_Helper.Methods;
using OfficeOpenXml;
using System.IO;

namespace Excel_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDir_Button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            DirPath = folderBrowserDialog1.SelectedPath;
            ListofFiles.Clear();
            ListofFiles.AddRange(Directory.GetFiles(DirPath).Select(Path.GetFileName)); // в список для выбора кладем названия файлов
            FilePath = GetSelectedData("Выбор базового файла");
            FileInfo XLSXFile = new FileInfo(FilePath); // создаем обертку для доступа к файлу
            ExPack = new ExcelPackage(XLSXFile); // подключаем Excel
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // некоммерческая лицензия
            WSheet = GetSelectedData("Выбор базового листа", "Выберите лист для поиска шапки таблицы");
            HatRange = GetHatRange(WSheet); // ищем диапазон шапки
            // создаем новый документ с шапкой
            // открываем последовательно файлы и 
            // ищем в каждой таблицу
            // копируем таблицу
            // сохраняем новый документ
            ExPack.Dispose(); // очищаем память
        }
    }
}
