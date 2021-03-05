
namespace Excel_Helper
{
    partial class SelectDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSelectSheet = new System.Windows.Forms.Button();
            this.ListData = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ButtonSelectSheet
            // 
            this.ButtonSelectSheet.Location = new System.Drawing.Point(94, 61);
            this.ButtonSelectSheet.Name = "ButtonSelectSheet";
            this.ButtonSelectSheet.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelectSheet.TabIndex = 2;
            this.ButtonSelectSheet.Text = "Выбрать";
            this.ButtonSelectSheet.UseVisualStyleBackColor = true;
            this.ButtonSelectSheet.Click += new System.EventHandler(this.ButtonSelectSheet_Click);
            // 
            // ListData
            // 
            this.ListData.FormattingEnabled = true;
            this.ListData.Location = new System.Drawing.Point(13, 32);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(235, 23);
            this.ListData.TabIndex = 3;
            // 
            // SelectDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 92);
            this.Controls.Add(this.ListData);
            this.Controls.Add(this.ButtonSelectSheet);
            this.Controls.Add(this.label1);
            this.Name = "SelectDataForm";
            this.Text = "SelectDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSelectSheet;
        public System.Windows.Forms.ComboBox ListData;
    }
}