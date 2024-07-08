namespace investigator
{
    partial class Form2
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
            this.downloadXML_btn = new System.Windows.Forms.Button();
            this.downloadReadme_btn = new System.Windows.Forms.Button();
            this.downloadExe_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadXML_btn
            // 
            this.downloadXML_btn.Location = new System.Drawing.Point(57, 97);
            this.downloadXML_btn.Name = "downloadXML_btn";
            this.downloadXML_btn.Size = new System.Drawing.Size(75, 23);
            this.downloadXML_btn.TabIndex = 0;
            this.downloadXML_btn.Text = "XML";
            this.downloadXML_btn.UseVisualStyleBackColor = true;
            this.downloadXML_btn.Click += new System.EventHandler(this.downloadXML_btn_Click);
            // 
            // downloadReadme_btn
            // 
            this.downloadReadme_btn.Location = new System.Drawing.Point(57, 20);
            this.downloadReadme_btn.Name = "downloadReadme_btn";
            this.downloadReadme_btn.Size = new System.Drawing.Size(75, 23);
            this.downloadReadme_btn.TabIndex = 1;
            this.downloadReadme_btn.Text = "Readme";
            this.downloadReadme_btn.UseVisualStyleBackColor = true;
            this.downloadReadme_btn.Click += new System.EventHandler(this.downloadReadme_btn_Click);
            // 
            // downloadExe_btn
            // 
            this.downloadExe_btn.Location = new System.Drawing.Point(57, 58);
            this.downloadExe_btn.Name = "downloadExe_btn";
            this.downloadExe_btn.Size = new System.Drawing.Size(75, 23);
            this.downloadExe_btn.TabIndex = 2;
            this.downloadExe_btn.Text = "EXE";
            this.downloadExe_btn.UseVisualStyleBackColor = true;
            this.downloadExe_btn.Click += new System.EventHandler(this.downloadExe_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downloadExe_btn);
            this.Controls.Add(this.downloadReadme_btn);
            this.Controls.Add(this.downloadXML_btn);
            this.Name = "Form2";
            this.Text = "Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadXML_btn;
        private System.Windows.Forms.Button downloadReadme_btn;
        private System.Windows.Forms.Button downloadExe_btn;
        private System.Windows.Forms.Label label1;
    }
}