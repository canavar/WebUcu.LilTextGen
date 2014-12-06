namespace WebUcu.LilTextGen
{
    partial class TextGenMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextGenMainForm));
            this.txtInputs = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.btnOpenTemplatesFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputs
            // 
            this.txtInputs.Location = new System.Drawing.Point(12, 56);
            this.txtInputs.MaxLength = 100000000;
            this.txtInputs.Multiline = true;
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInputs.Size = new System.Drawing.Size(513, 92);
            this.txtInputs.TabIndex = 0;
            this.txtInputs.Text = "input1,input2,input3\r\ninput4,input5,input6";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(407, 252);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(13, 154);
            this.txtTemplate.MaxLength = 100000000;
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTemplate.Size = new System.Drawing.Size(513, 92);
            this.txtTemplate.TabIndex = 2;
            this.txtTemplate.Text = "some text {0}, some text {1}, some text {2}.";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 281);
            this.txtResults.MaxLength = 1000000000;
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(513, 173);
            this.txtResults.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(245, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 461);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(407, 460);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(117, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(435, 27);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(91, 23);
            this.btnSaveTemplate.TabIndex = 7;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(13, 27);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(121, 21);
            this.cmbTemplates.TabIndex = 8;
            this.cmbTemplates.Text = "Select Template";
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.Location = new System.Drawing.Point(141, 27);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(87, 23);
            this.btnLoadTemplate.TabIndex = 9;
            this.btnLoadTemplate.Text = "Load Template";
            this.btnLoadTemplate.UseVisualStyleBackColor = true;
            this.btnLoadTemplate.Click += new System.EventHandler(this.btnLoadTemplate_Click);
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Location = new System.Drawing.Point(303, 30);
            this.txtTemplateName.MaxLength = 200;
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(125, 20);
            this.txtTemplateName.TabIndex = 10;
            // 
            // btnOpenTemplatesFolder
            // 
            this.btnOpenTemplatesFolder.Location = new System.Drawing.Point(237, 461);
            this.btnOpenTemplatesFolder.Name = "btnOpenTemplatesFolder";
            this.btnOpenTemplatesFolder.Size = new System.Drawing.Size(134, 23);
            this.btnOpenTemplatesFolder.TabIndex = 11;
            this.btnOpenTemplatesFolder.Text = "Open Templates Folder";
            this.btnOpenTemplatesFolder.UseVisualStyleBackColor = true;
            this.btnOpenTemplatesFolder.Click += new System.EventHandler(this.btnOpenTemplatesFolder_Click);
            // 
            // TextGenMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 493);
            this.Controls.Add(this.btnOpenTemplatesFolder);
            this.Controls.Add(this.txtTemplateName);
            this.Controls.Add(this.btnLoadTemplate);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextGenMainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LilTextGen By WebUcu.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputs;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Button btnOpenTemplatesFolder;
    }
}