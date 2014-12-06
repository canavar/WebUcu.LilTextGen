using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WebUcu.LilTextGen
{
    public partial class TextGenMainForm : Form
    {
        ConfigurationHelper configurationHelper;

        public TextGenMainForm()
        {
            InitializeComponent();

            configurationHelper = new ConfigurationHelper();

            string filePattern = string.Format("*.{0}", configurationHelper.TemplateExtension);
            var templateFiles = Directory.EnumerateFiles(configurationHelper.TemplateRootFolder, filePattern);

            foreach (string templateFilePath in templateFiles)
            {
                string fileName = templateFilePath.Replace(configurationHelper.TemplateRootFolder + "\\", "");
                cmbTemplates.Items.Add(fileName.Remove(fileName.LastIndexOf('.')));
            }
        }
		
		private void btnGenerate_Click(object sender, EventArgs e)
        {
            string template = txtTemplate.Text;
            string inputs = txtInputs.Text;
            string[] inputRows = inputs.Split('\r');
            StringBuilder sbResult = new StringBuilder();

            foreach (string inputRow in inputRows)
            {
                string resultString = inputRow.Replace("\n", "");
                if (resultString.Length > 0)
                {
                    string[] inputValues = resultString.Split(',');
                    if (inputValues.Length > 0)
                    {
                        sbResult.AppendFormat(template, inputValues);
                        sbResult.AppendFormat("\r\n");
                    }
                }
            }

            txtResults.Text = sbResult.ToString();
            lblStatus.Text = String.Format("{0} rows generated.", inputRows.Length);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputs.Text = string.Empty;
            txtTemplate.Text = string.Empty;
            txtResults.Text = string.Empty;
            lblStatus.Text = string.Empty;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResults.Text);
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTemplateName.Text == string.Empty)
                {
                    MessageBox.Show("Please specify a template name.");
                    return;
                }

                string templateName = string.Format("{0}.{1}", txtTemplateName.Text, configurationHelper.TemplateExtension);
                string templateFullPath = Path.Combine(configurationHelper.TemplateRootFolder, templateName);

                //if (File.Exists(templateFullPath))
                //{
                //    MessageBox.Show("This template already exists. Please specify a different template name.");
                //    return;
                //}

                string templateContent = txtTemplate.Text;

                File.WriteAllText(templateFullPath, templateContent);
                lblStatus.Text = "Template saved!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured : " + ex.Message + " | " + ex.StackTrace);
            }
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            string templateName = string.Format("{0}.{1}", cmbTemplates.SelectedItem, configurationHelper.TemplateExtension);
            string templateFullPath = Path.Combine(configurationHelper.TemplateRootFolder, templateName);

            if (!File.Exists(templateFullPath))
            {
                MessageBox.Show("Template can not be found. Please select a different template.");
                return;
            }

            string template = File.ReadAllText(templateFullPath);
            txtTemplate.Text = template;
            txtTemplateName.Text = cmbTemplates.SelectedItem.ToString();
        }

        private void btnOpenTemplatesFolder_Click(object sender, EventArgs e)
        {
            Process.Start(configurationHelper.TemplateRootFolder);
        }
    }
}
