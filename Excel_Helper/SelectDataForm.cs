using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Excel_Helper.GlobalProp;


namespace Excel_Helper
{
    public partial class SelectDataForm : Form
    {
        public SelectDataForm()
        {
            InitializeComponent();
        }

        private void ButtonSelectSheet_Click(object sender, EventArgs e)
        {
            if (ListData.Text != "")
            {
                CurrentData = ListData.Text;
                ActiveForm.Close();
                ActiveForm.Dispose();
            }
            else MessageBox.Show("Имя не должно быть пустым!");
        }
    }
}
