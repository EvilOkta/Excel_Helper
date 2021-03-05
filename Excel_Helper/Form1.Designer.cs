
namespace Excel_Helper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenDir_Button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // OpenDir_Button
            // 
            this.OpenDir_Button.Location = new System.Drawing.Point(13, 13);
            this.OpenDir_Button.Name = "OpenDir_Button";
            this.OpenDir_Button.Size = new System.Drawing.Size(75, 39);
            this.OpenDir_Button.TabIndex = 0;
            this.OpenDir_Button.Text = "Открыть папку";
            this.OpenDir_Button.UseVisualStyleBackColor = true;
            this.OpenDir_Button.Click += new System.EventHandler(this.OpenDir_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 128);
            this.Controls.Add(this.OpenDir_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenDir_Button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

