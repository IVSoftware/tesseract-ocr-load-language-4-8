namespace tesseract_ocr_load_language_4_8
{
    partial class MainForm
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
            this.buttonLoadLanguage = new System.Windows.Forms.Button();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadLanguage
            // 
            this.buttonLoadLanguage.Location = new System.Drawing.Point(23, 23);
            this.buttonLoadLanguage.Name = "buttonLoadLanguage";
            this.buttonLoadLanguage.Size = new System.Drawing.Size(162, 60);
            this.buttonLoadLanguage.TabIndex = 0;
            this.buttonLoadLanguage.Text = "Load Language";
            this.buttonLoadLanguage.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(23, 113);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(162, 60);
            this.buttonOpenFolder.TabIndex = 0;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.buttonLoadLanguage);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadLanguage;
        private System.Windows.Forms.Button buttonOpenFolder;
    }
}

