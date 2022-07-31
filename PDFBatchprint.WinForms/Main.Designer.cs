
namespace PDFBatchprint.WinForms
{
    partial class Main
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
            this.SelectPDFButton = new System.Windows.Forms.Button();
            this.SelectListButton = new System.Windows.Forms.Button();
            this.FileTypeA4RadioButton = new System.Windows.Forms.RadioButton();
            this.PrintColorYesRadioButton = new System.Windows.Forms.RadioButton();
            this.PrintColorNoRadioButton = new System.Windows.Forms.RadioButton();
            this.PrintFormatA3 = new System.Windows.Forms.RadioButton();
            this.PrintFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintColorGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SelectedFilesPanel = new System.Windows.Forms.Panel();
            this.OpenPDFsDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenListDialog = new System.Windows.Forms.OpenFileDialog();
            this.PrintersComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedFilesLabel = new System.Windows.Forms.Label();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.SelectNoneButton = new System.Windows.Forms.Button();
            this.PrintFormatGroupBox.SuspendLayout();
            this.PrintColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectPDFButton
            // 
            this.SelectPDFButton.AccessibleName = "SelectPDFButton";
            this.SelectPDFButton.Location = new System.Drawing.Point(11, 12);
            this.SelectPDFButton.Name = "SelectPDFButton";
            this.SelectPDFButton.Size = new System.Drawing.Size(120, 29);
            this.SelectPDFButton.TabIndex = 0;
            this.SelectPDFButton.Text = "Selecteer PDFs";
            this.SelectPDFButton.UseVisualStyleBackColor = true;
            this.SelectPDFButton.Click += new System.EventHandler(this.SelectPDFButton_Click);
            // 
            // SelectListButton
            // 
            this.SelectListButton.AccessibleName = "SelectListButton";
            this.SelectListButton.Location = new System.Drawing.Point(138, 12);
            this.SelectListButton.Name = "SelectListButton";
            this.SelectListButton.Size = new System.Drawing.Size(118, 29);
            this.SelectListButton.TabIndex = 1;
            this.SelectListButton.Text = "Selecteer Lijst";
            this.SelectListButton.UseVisualStyleBackColor = true;
            this.SelectListButton.Click += new System.EventHandler(this.SelectListButton_Click);
            // 
            // FileTypeA4RadioButton
            // 
            this.FileTypeA4RadioButton.AccessibleName = "PrintFormatA4RadioButton";
            this.FileTypeA4RadioButton.AutoSize = true;
            this.FileTypeA4RadioButton.Checked = true;
            this.FileTypeA4RadioButton.Location = new System.Drawing.Point(6, 27);
            this.FileTypeA4RadioButton.Name = "FileTypeA4RadioButton";
            this.FileTypeA4RadioButton.Size = new System.Drawing.Size(48, 24);
            this.FileTypeA4RadioButton.TabIndex = 2;
            this.FileTypeA4RadioButton.TabStop = true;
            this.FileTypeA4RadioButton.Text = "A4";
            this.FileTypeA4RadioButton.UseVisualStyleBackColor = true;
            this.FileTypeA4RadioButton.CheckedChanged += new System.EventHandler(this.FileTypeA4RadioButton_CheckedChanged);
            // 
            // PrintColorYesRadioButton
            // 
            this.PrintColorYesRadioButton.AccessibleName = "PrintColorYesRadioButton";
            this.PrintColorYesRadioButton.AutoSize = true;
            this.PrintColorYesRadioButton.Checked = true;
            this.PrintColorYesRadioButton.Location = new System.Drawing.Point(6, 27);
            this.PrintColorYesRadioButton.Name = "PrintColorYesRadioButton";
            this.PrintColorYesRadioButton.Size = new System.Drawing.Size(64, 24);
            this.PrintColorYesRadioButton.TabIndex = 3;
            this.PrintColorYesRadioButton.TabStop = true;
            this.PrintColorYesRadioButton.Text = "Kleur";
            this.PrintColorYesRadioButton.UseVisualStyleBackColor = true;
            this.PrintColorYesRadioButton.CheckedChanged += new System.EventHandler(this.PrintColorYesRadioButton_CheckedChanged);
            // 
            // PrintColorNoRadioButton
            // 
            this.PrintColorNoRadioButton.AccessibleName = "PrintColorNoRadioButton";
            this.PrintColorNoRadioButton.AutoSize = true;
            this.PrintColorNoRadioButton.Location = new System.Drawing.Point(6, 51);
            this.PrintColorNoRadioButton.Name = "PrintColorNoRadioButton";
            this.PrintColorNoRadioButton.Size = new System.Drawing.Size(97, 24);
            this.PrintColorNoRadioButton.TabIndex = 4;
            this.PrintColorNoRadioButton.Text = "Zwart/Wit";
            this.PrintColorNoRadioButton.UseVisualStyleBackColor = true;
            this.PrintColorNoRadioButton.CheckedChanged += new System.EventHandler(this.PrintColorNoRadioButton_CheckedChanged);
            // 
            // PrintFormatA3
            // 
            this.PrintFormatA3.AccessibleName = "PrintFormatA3";
            this.PrintFormatA3.AutoSize = true;
            this.PrintFormatA3.Location = new System.Drawing.Point(6, 51);
            this.PrintFormatA3.Name = "PrintFormatA3";
            this.PrintFormatA3.Size = new System.Drawing.Size(48, 24);
            this.PrintFormatA3.TabIndex = 5;
            this.PrintFormatA3.Text = "A3";
            this.PrintFormatA3.UseVisualStyleBackColor = true;
            this.PrintFormatA3.CheckedChanged += new System.EventHandler(this.PrintFormatA3_CheckedChanged);
            // 
            // PrintFormatGroupBox
            // 
            this.PrintFormatGroupBox.AccessibleName = "PrintFormatGroupBox";
            this.PrintFormatGroupBox.Controls.Add(this.FileTypeA4RadioButton);
            this.PrintFormatGroupBox.Controls.Add(this.PrintFormatA3);
            this.PrintFormatGroupBox.Location = new System.Drawing.Point(305, 12);
            this.PrintFormatGroupBox.Name = "PrintFormatGroupBox";
            this.PrintFormatGroupBox.Size = new System.Drawing.Size(119, 80);
            this.PrintFormatGroupBox.TabIndex = 6;
            this.PrintFormatGroupBox.TabStop = false;
            this.PrintFormatGroupBox.Text = "Print Formaat";
            // 
            // PrintColorGroupBox
            // 
            this.PrintColorGroupBox.AccessibleName = "PrintColorGroupBox";
            this.PrintColorGroupBox.Controls.Add(this.PrintColorYesRadioButton);
            this.PrintColorGroupBox.Controls.Add(this.PrintColorNoRadioButton);
            this.PrintColorGroupBox.Location = new System.Drawing.Point(431, 12);
            this.PrintColorGroupBox.Name = "PrintColorGroupBox";
            this.PrintColorGroupBox.Size = new System.Drawing.Size(128, 80);
            this.PrintColorGroupBox.TabIndex = 7;
            this.PrintColorGroupBox.TabStop = false;
            this.PrintColorGroupBox.Text = "Kleur";
            // 
            // PrintButton
            // 
            this.PrintButton.AccessibleName = "PrintButton";
            this.PrintButton.Enabled = false;
            this.PrintButton.Location = new System.Drawing.Point(465, 536);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(94, 32);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SelectedFilesPanel
            // 
            this.SelectedFilesPanel.AccessibleName = "SelectedFilesPanel";
            this.SelectedFilesPanel.AutoScroll = true;
            this.SelectedFilesPanel.Location = new System.Drawing.Point(13, 117);
            this.SelectedFilesPanel.Name = "SelectedFilesPanel";
            this.SelectedFilesPanel.Size = new System.Drawing.Size(546, 413);
            this.SelectedFilesPanel.TabIndex = 9;
            // 
            // OpenPDFsDialog
            // 
            this.OpenPDFsDialog.FileName = "OpenPDFsDialog";
            this.OpenPDFsDialog.Filter = "PDF bestanden|*.pdf|Alle bestanden|*.*";
            this.OpenPDFsDialog.Multiselect = true;
            this.OpenPDFsDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenPDFsDialog_FileOk);
            // 
            // OpenListDialog
            // 
            this.OpenListDialog.FileName = "OpenListDialog";
            this.OpenListDialog.Filter = "Tekst bestanden|*.txt|Excel bestanden|*.xls|Alle bestanden|*.*";
            this.OpenListDialog.Multiselect = true;
            this.OpenListDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenListDialog_FileOk);
            // 
            // PrintersComboBox
            // 
            this.PrintersComboBox.AccessibleName = "PrintersComboBox";
            this.PrintersComboBox.Enabled = false;
            this.PrintersComboBox.FormattingEnabled = true;
            this.PrintersComboBox.Location = new System.Drawing.Point(11, 537);
            this.PrintersComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintersComboBox.Name = "PrintersComboBox";
            this.PrintersComboBox.Size = new System.Drawing.Size(446, 28);
            this.PrintersComboBox.TabIndex = 0;
            // 
            // SelectedFilesLabel
            // 
            this.SelectedFilesLabel.AccessibleName = "SelectedFilesLabel";
            this.SelectedFilesLabel.AutoSize = true;
            this.SelectedFilesLabel.Location = new System.Drawing.Point(13, 94);
            this.SelectedFilesLabel.Name = "SelectedFilesLabel";
            this.SelectedFilesLabel.Size = new System.Drawing.Size(179, 20);
            this.SelectedFilesLabel.TabIndex = 1;
            this.SelectedFilesLabel.Text = "Geselecteerde bestanden:";
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.AccessibleName = "SelectAllButton";
            this.SelectAllButton.Enabled = false;
            this.SelectAllButton.Location = new System.Drawing.Point(11, 58);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(120, 29);
            this.SelectAllButton.TabIndex = 10;
            this.SelectAllButton.Text = "Selecteer Alles";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // SelectNoneButton
            // 
            this.SelectNoneButton.AccessibleName = "SelectNoneButton";
            this.SelectNoneButton.Enabled = false;
            this.SelectNoneButton.Location = new System.Drawing.Point(138, 58);
            this.SelectNoneButton.Name = "SelectNoneButton";
            this.SelectNoneButton.Size = new System.Drawing.Size(118, 29);
            this.SelectNoneButton.TabIndex = 11;
            this.SelectNoneButton.Text = "Selecteer Geen";
            this.SelectNoneButton.UseVisualStyleBackColor = true;
            this.SelectNoneButton.Click += new System.EventHandler(this.SelectNoneButton_Click);
            // 
            // Main
            // 
            this.AccessibleName = "PrintButton";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 577);
            this.Controls.Add(this.SelectNoneButton);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.SelectedFilesLabel);
            this.Controls.Add(this.SelectedFilesPanel);
            this.Controls.Add(this.PrintersComboBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PrintColorGroupBox);
            this.Controls.Add(this.PrintFormatGroupBox);
            this.Controls.Add(this.SelectListButton);
            this.Controls.Add(this.SelectPDFButton);
            this.Name = "Main";
            this.Text = "PDFBatchprint";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PrintFormatGroupBox.ResumeLayout(false);
            this.PrintFormatGroupBox.PerformLayout();
            this.PrintColorGroupBox.ResumeLayout(false);
            this.PrintColorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectPDFButton;
        private System.Windows.Forms.Button SelectListButton;
        private System.Windows.Forms.RadioButton FileTypeA4RadioButton;
        private System.Windows.Forms.RadioButton PrintColorYesRadioButton;
        private System.Windows.Forms.RadioButton PrintColorNoRadioButton;
        private System.Windows.Forms.RadioButton PrintFormatA3;
        private System.Windows.Forms.GroupBox PrintFormatGroupBox;
        private System.Windows.Forms.GroupBox PrintColorGroupBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.OpenFileDialog OpenPDFsDialog;
        private System.Windows.Forms.OpenFileDialog OpenListDialog;
        private System.Windows.Forms.ComboBox PrintersComboBox;
        private System.Windows.Forms.Panel SelectedFilesPanel;
        private System.Windows.Forms.Label SelectedFilesLabel;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button SelectNoneButton;
    }
}

