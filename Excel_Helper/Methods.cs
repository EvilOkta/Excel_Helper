using System;
using System.Collections.Generic;
using System.Text;
using static Excel_Helper.GlobalProp;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml.Style;

namespace Excel_Helper
{
    class Methods
    {
        static public string GetHatRange(ExcelWorksheet curSheet)
        {
            string HatRange = "";
            int Rcell = 0, CCell = 1;
            ExcelRange testCell;
            bool isBordered, isnotValued = false;

            do // ищем первую ячейку в диапазоне 10 столбцов 20 рядов, которая пройдет тест на наличие рамок
            {
                Rcell++;
                testCell = curSheet.Cells[Rcell, CCell];
                isBordered = CheckBorder(testCell);
                if (Rcell > 20)
                {
                    Rcell = 0;
                    CCell++;
                }
                if (CCell > 10)
                {
                    MessageBox.Show("Таблица не найдена");
                    break;
                }
            } while (!isBordered);

            int delta = 0;
            object getvalue;

            do
            {
                getvalue = curSheet.Cells[testCell.Start.Row, testCell.Start.Column + delta].Value ?? String.Empty;
                if (getvalue.ToString() == String.Empty) isnotValued = true;
                delta++;
            } while (!isnotValued);
            delta -= 2; // коррекция смещения
            testCell = curSheet.Cells[testCell.Start.Row, testCell.Start.Column, testCell.Start.Row, testCell.Start.Column + delta];
            MessageBox.Show(testCell.Address);
            return testCell.Address;
        }

        static private bool CheckBorder(ExcelRange testrange)
        {
            int checkcount = 0;
            if (testrange.Style.Border.Bottom.Style != ExcelBorderStyle.None) checkcount++;
            if (testrange.Style.Border.Top.Style != ExcelBorderStyle.None) checkcount++;
            if (testrange.Style.Border.Left.Style != ExcelBorderStyle.None) checkcount++;
            if (testrange.Style.Border.Right.Style != ExcelBorderStyle.None) checkcount++;
            return checkcount == 4;
        }

        static public string GetTableRange(ExcelWorksheet curSheet)
        {
            string TableRange = "";
            //
            return TableRange;
        }

        static public ExcelWorksheet GetSelectedData(string formtext, string labeltext)
        {
            ListSheet = ExPack.Workbook.Worksheets; // список листов
            SelectDataForm SWForm = new SelectDataForm { Text = formtext }; // создаем форму с выбором
            SWForm.label1.Text = labeltext;
            SWForm.ListData.Items.Clear();
            foreach (ExcelWorksheet worksheet in ListSheet) // заполняем перечнем листов
            {
                SWForm.ListData.Items.Add(worksheet.Name);
            }
            SWForm.ListData.Text = SWForm.ListData.Items[0].ToString(); // выставляем первый лист по умолчанию
            SWForm.ShowDialog();
            return ExPack.Workbook.Worksheets[CurrentData]; // выбор активного листа
        }

        static public string GetSelectedData(string formtext) // перегруженный метод для string выбор файла
        {
            SelectDataForm SWForm = new SelectDataForm { Text = formtext }; // создаем форму с выбором
            SWForm.label1.Text = formtext;
            SWForm.ListData.Items.Clear();
            foreach (string fn in ListofFiles) // заполняем перечнем файлов
            {
                SWForm.ListData.Items.Add(fn);
            }
            ListofFiles.Clear();
            ListofFiles.AddRange(Directory.GetFiles(DirPath));
            SWForm.ListData.Text = SWForm.ListData.Items[0].ToString(); // выставляем первый файл по умолчанию
            SWForm.ShowDialog();
            return ListofFiles[SWForm.ListData.SelectedIndex]; // выбор активного файла
        }
    }
}
