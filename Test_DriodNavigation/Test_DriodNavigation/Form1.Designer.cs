namespace Test_DriodNavigation {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ImportFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Commands = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_EndLocation = new System.Windows.Forms.Label();
            this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driod Navigation Controle";
            // 
            // Btn_ImportFiles
            // 
            this.Btn_ImportFiles.Location = new System.Drawing.Point(12, 29);
            this.Btn_ImportFiles.Name = "Btn_ImportFiles";
            this.Btn_ImportFiles.Size = new System.Drawing.Size(170, 50);
            this.Btn_ImportFiles.TabIndex = 1;
            this.Btn_ImportFiles.Text = "Import Commands";
            this.Btn_ImportFiles.UseVisualStyleBackColor = true;
            this.Btn_ImportFiles.Click += new System.EventHandler(this.Btn_ImportFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Location:";
            // 
            // TXT_Commands
            // 
            this.TXT_Commands.Location = new System.Drawing.Point(188, 12);
            this.TXT_Commands.Multiline = true;
            this.TXT_Commands.Name = "TXT_Commands";
            this.TXT_Commands.Size = new System.Drawing.Size(150, 125);
            this.TXT_Commands.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "(0,0)";
            // 
            // LBL_EndLocation
            // 
            this.LBL_EndLocation.AutoSize = true;
            this.LBL_EndLocation.Location = new System.Drawing.Point(108, 120);
            this.LBL_EndLocation.Name = "LBL_EndLocation";
            this.LBL_EndLocation.Size = new System.Drawing.Size(0, 17);
            this.LBL_EndLocation.TabIndex = 6;
            // 
            // FileBrowser
            // 
            this.FileBrowser.FileName = "Select A File";
            this.FileBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.FileBrowser_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 150);
            this.Controls.Add(this.LBL_EndLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Commands);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_ImportFiles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ImportFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Commands;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_EndLocation;
        private System.Windows.Forms.OpenFileDialog FileBrowser;
    }
}

