namespace COMP123_Programming2_Assignment06
{
    partial class SalesBonusForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonusForm));
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.WarningProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(52, 176);
            this.EmployeeNameLabel.MinimumSize = new System.Drawing.Size(160, 20);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(160, 20);
            this.EmployeeNameLabel.TabIndex = 0;
            this.EmployeeNameLabel.Text = "Employee\'s Name";
            this.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(52, 211);
            this.EmployeeIDLabel.MinimumSize = new System.Drawing.Size(160, 20);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(160, 20);
            this.EmployeeIDLabel.TabIndex = 1;
            this.EmployeeIDLabel.Text = "Employee ID:";
            this.EmployeeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedLabel.Location = new System.Drawing.Point(52, 247);
            this.HoursWorkedLabel.MinimumSize = new System.Drawing.Size(160, 20);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(160, 20);
            this.HoursWorkedLabel.TabIndex = 2;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            this.HoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.Location = new System.Drawing.Point(52, 281);
            this.TotalSalesLabel.MinimumSize = new System.Drawing.Size(160, 20);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(160, 20);
            this.TotalSalesLabel.TabIndex = 3;
            this.TotalSalesLabel.Text = "Total Sales:";
            this.TotalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.Location = new System.Drawing.Point(52, 313);
            this.SalesBonusLabel.MinimumSize = new System.Drawing.Size(160, 20);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(160, 20);
            this.SalesBonusLabel.TabIndex = 4;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            this.SalesBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(60, 366);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(97, 33);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(197, 366);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(97, 33);
            this.PrintButton.TabIndex = 6;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(333, 366);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(97, 33);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(259, 173);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(214, 26);
            this.EmployeeNameTextBox.TabIndex = 8;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(259, 208);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(154, 26);
            this.EmployeeIDTextBox.TabIndex = 9;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(259, 247);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(154, 26);
            this.HoursWorkedTextBox.TabIndex = 10;
            this.HoursWorkedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HoursWorkedTextBox_Validating);
            this.HoursWorkedTextBox.Validated += new System.EventHandler(this.HoursWorkedTextBox_Validated);
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesTextBox.Location = new System.Drawing.Point(259, 281);
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.Size = new System.Drawing.Size(154, 26);
            this.TotalSalesTextBox.TabIndex = 11;
            this.TotalSalesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TotalSalesTextBox_Validating);
            this.TotalSalesTextBox.Validated += new System.EventHandler(this.TotalSalesTextBox_Validated);
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusTextBox.Location = new System.Drawing.Point(259, 313);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(154, 26);
            this.SalesBonusTextBox.TabIndex = 12;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = global::COMP123_Programming2_Assignment06.Properties.Resources.MailOrderCompanyBonusImprove;
            this.MainPictureBox.Location = new System.Drawing.Point(49, 20);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(166, 132);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 13;
            this.MainPictureBox.TabStop = false;
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageGroupBox.Location = new System.Drawing.Point(247, 20);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(200, 109);
            this.LanguageGroupBox.TabIndex = 14;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Language";
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(23, 70);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(96, 24);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(23, 36);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(86, 24);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // WarningProvider
            // 
            this.WarningProvider.ContainerControl = this;
            this.WarningProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("WarningProvider.Icon")));
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // SalesBonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(493, 420);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalSalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Name = "SalesBonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.ErrorProvider WarningProvider;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

