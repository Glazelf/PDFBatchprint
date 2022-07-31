using PDFBatchprint.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PDFBatchprint.WinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        PrinterHandler PrinterHandler = new PrinterHandler();

        string[] SelectedFilesPaths;
        bool PrintFromList = false;
        bool ColorBool = true;
        string PrintFormat = "A4";

        private void SelectPDFButton_Click(object sender, EventArgs e)
        {
            // Logic for printing PDFs
            if (OpenPDFsDialog.ShowDialog() == DialogResult.OK)
            {
                ClearPanel(SelectedFilesPanel);

                SelectedFilesPaths = OpenPDFsDialog.FileNames;

                //PrinterHandler.PrinterDialog();

                FillPanel(SelectedFilesPanel, SelectedFilesPaths);

                PrintFromList = false;
                PrintButton.Enabled = true;
                SelectAllButton.Enabled = true;
                SelectNoneButton.Enabled = true;
            }
        }

        private void SelectListButton_Click(object sender, EventArgs e)
        {
            // Logic for printing text/excel files containing lists of PDFs
            if (OpenListDialog.ShowDialog() == DialogResult.OK)
            {
                ClearPanel(SelectedFilesPanel);

                // Add logic to get file paths from files here
                SelectedFilesPaths = OpenListDialog.FileNames;

                FillPanel(SelectedFilesPanel, SelectedFilesPaths);

                PrintFromList = true;
                PrintButton.Enabled = true;
                SelectAllButton.Enabled = true;
                SelectNoneButton.Enabled = true;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (PrintersComboBox.Text.Length < 1)
            {
                MessageBox.Show("Er is geen printer geselecteerd.",
                    "Foutmelding",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PrintFromList == true)
            {
                // Get all file paths from list
            }

            Collection<Control[]> ControlCollection = new Collection<Control[]>();
            foreach (Control control in SelectedFilesPanel.Controls)
            {
                if (control is CheckBox box)
                {
                    if (box.Checked == true)
                    {
                        string labelName = StringHandler.ReplaceLastOccurrence(box.Name, "Checkbox", "Label");
                        // Change label string and find match between checkbox and label
                        labelName = labelName[1..];
                        Control label = SelectedFilesPanel.Controls.Find(labelName, false)[0];
                        Control[] CheckboxLabelDuo = { box, label };
                        ControlCollection.Add(CheckboxLabelDuo);
                    }
                }
                if (ControlCollection.Count < 1)
                {
                    MessageBox.Show("Er zijn geen bestanden aangevinkt.",
                        "Foutmelding",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            List<string> SelectedFilesPathsList = new List<string>();
            for (int i = 0; i < ControlCollection.Count; i++)
            {
                Control[] control = ControlCollection[i];
                Control label = control[1];
                SelectedFilesPathsList.Add(label.Name);
            }
            string[] SelectedFilePaths = SelectedFilesPathsList.ToArray();

            foreach (string FilePath in SelectedFilesPaths)
            {
                string FileName = StringHandler.FilePathToName(FilePath);
                PrinterHandler.PrintPDF(PrintersComboBox.Text, FilePath, PrintFormat, ColorBool);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Put all printers in a list
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                PrintersComboBox.Items.Add(printerName);
                PrintersComboBox.Enabled = true;
            }
        }

        private void PrintColorYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColorBool = true;
        }

        private void PrintColorNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColorBool = false;
        }

        private void FileTypeA4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PrintFormat = "A4";
        }

        private void PrintFormatA3_CheckedChanged(object sender, EventArgs e)
        {
            PrintFormat = "A3";
        }

        private void OpenPDFsDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenListDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in SelectedFilesPanel.Controls)
            {
                if (control is CheckBox box)
                {
                    box.Checked = true;
                }
            }
        }

        private void SelectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in SelectedFilesPanel.Controls)
            {
                if (control is CheckBox box)
                {
                    box.Checked = false;
                }
            }
        }

        private static void ClearPanel(Control control)
        {
            while (control.Controls.Count > 0) control.Controls[0].Dispose();
        }

        private static void FillPanel(Control control, string[] SelectedFilePaths)
        {
            int i = 0;
            foreach (string FilePath in SelectedFilePaths)
            {
                string FileName = StringHandler.FilePathToName(FilePath);
                CheckBox box = new CheckBox
                {
                    Tag = $"${FileName}Checkbox",
                    Name = $"${FilePath}Checkbox",
                    AutoSize = true,
                    Checked = true,
                    Location = new Point(10, i * 25 + 10)
                };
                Label label = new Label
                {
                    Name = $"{FilePath}Label",
                    Text = $"{FileName}",
                    AutoSize = true,
                    Location = new Point(25, i * 25 + 7)
                };
                control.Controls.Add(box);
                control.Controls.Add(label);
                i++;
            }
        }
    }
}
