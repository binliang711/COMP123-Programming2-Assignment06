using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace COMP123_Programming2_Assignment06
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }

        // ENGLISH RADIO BUTTON HANDLER - Checked Changed event
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.TitleBarStringEnglish;

            LanguageGroupBox.Text = Properties.Resources.GroupBoxEnglish;

            EnglishRadioButton.Text = Properties.Resources.EnglishRadioButtonEnglish;

            FrenchRadioButton.Text = Properties.Resources.FrenchRadioButtonEnglish;

            EmployeeNameLabel.Text = Properties.Resources.EmployeeNameLabelEnglish;
            EmployeeNameLabel.TextAlign = ContentAlignment.MiddleRight;

            EmployeeIDLabel.Text = Properties.Resources.EmployeeIDLabelEnglish;
            EmployeeIDLabel.TextAlign = ContentAlignment.MiddleRight;

            HoursWorkedLabel.Text = Properties.Resources.HoursWorkedLabelEnglish;
            HoursWorkedLabel.TextAlign = ContentAlignment.MiddleRight;
            
            TotalSalesLabel.Text = Properties.Resources.TotalSalesLabelEnglish;
            TotalSalesLabel.TextAlign = ContentAlignment.MiddleRight;

            SalesBonusLabel.Text = Properties.Resources.SalesBonusLabelEnglish;
            SalesBonusLabel.TextAlign = ContentAlignment.MiddleRight;

            CalculateButton.Text = Properties.Resources.CalculateButtonStringEnglish;

            NextButton.Text = Properties.Resources.NextButtonStringEnglish;

            PrintButton.Text = Properties.Resources.PrintButtonStringEnglish;
        }

        // FRENCH RADIO BUTTON HANDLER - Checked Changed event
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.TitleBarStringFrench;

            LanguageGroupBox.Text = Properties.Resources.GroupBoxFrench;

            EnglishRadioButton.Text = Properties.Resources.EnglishRadioButtonFrench;

            FrenchRadioButton.Text = Properties.Resources.FrenchRadioButtonFrench;

            EmployeeNameLabel.Text = Properties.Resources.EmployeeNameLabelFrench;

            EmployeeIDLabel.Text = Properties.Resources.EmployeeIDLabelFrench;

            HoursWorkedLabel.Text = Properties.Resources.HoursWorkedLabelFrench;

            TotalSalesLabel.Text = Properties.Resources.TotalSalesLabelFrench;

            SalesBonusLabel.Text = Properties.Resources.SalesBonusLabelFrench;

            CalculateButton.Text = Properties.Resources.CalculateButtonStringFrench;

            NextButton.Text = Properties.Resources.NextButtonStringFrench;

            PrintButton.Text = Properties.Resources.PrintButtonStringFrench;
        }

        
        private void HoursWorkedTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "";
            int hoursWorked = Convert.ToInt32(HoursWorkedTextBox.Text);

            if (hoursWorked > 160 || hoursWorked <= 0)
            {
                errorMessage = "Maximum working hours must be less than or equal to 160 hours, or greater than zero!";
                WarningProvider.SetError(HoursWorkedTextBox, errorMessage);
                HoursWorkedTextBox.SelectAll();
                e.Cancel = true;
            }
            else
            {
                errorMessage = "";
            }
        }

        private void HoursWorkedTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(HoursWorkedTextBox, "");
        }

        private void TotalSalesTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "";                    
            string totalSales ="";

            if (string.IsNullOrEmpty(TotalSalesTextBox.Text))
            {
                errorMessage = "Employee name can't be null or empty!";
                WarningProvider.SetError(TotalSalesTextBox, errorMessage);
                TotalSalesTextBox.SelectAll();
                e.Cancel = true;
            }
            else if (Convert.ToDouble(TotalSalesTextBox.Text) <= 0)
            {
                errorMessage = "Total sales must greater than zero!";
                WarningProvider.SetError(TotalSalesTextBox, errorMessage);
                TotalSalesTextBox.SelectAll();
                e.Cancel = true;
            }
            else
            {
                try
                {
                    double value = Double.Parse(TotalSalesTextBox.Text, NumberStyles.Currency);
                    totalSales = string.Format("{0:C2}", value);
                    TotalSalesTextBox.Text = totalSales;
                }
                catch (Exception)
                {
                    if (totalSales != TotalSalesTextBox.Text)
                    {
                        errorMessage = "The input value must use standard currency format!";
                        WarningProvider.SetError(TotalSalesTextBox, errorMessage);
                        TotalSalesTextBox.SelectAll();
                        e.Cancel = true;
                    }
                    else
                    {
                        errorMessage = "";
                    }
                }
            }        
        }

        private void TotalSalesTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(TotalSalesTextBox, "");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int hoursWorked = Convert.ToInt32(HoursWorkedTextBox.Text);
            double percentageOfHoursWorked = Convert.ToDouble(hoursWorked) / 160;
            double value = Double.Parse(TotalSalesTextBox.Text, NumberStyles.Currency);
            double totalBonusAmount = value * 0.02;
            double salesBonus = totalBonusAmount * percentageOfHoursWorked;
            string salesBonusDisplay = string.Format("{0:C2}", salesBonus);
            SalesBonusTextBox.Text = salesBonusDisplay;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            HoursWorkedTextBox.Text = "";
            SalesBonusTextBox.Text = "";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

     

        private void EmployeeNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrEmpty(EmployeeNameTextBox.Text))
            {
                errorMessage = "Employee name can't be null or empty!"; 
                WarningProvider.SetError(EmployeeNameTextBox, errorMessage);
                EmployeeNameTextBox.SelectAll();
                e.Cancel = true;
            }
            else
            {
                WarningProvider.SetError(EmployeeNameTextBox, "");
            }            
        }

        private void EmployeeNameTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(EmployeeNameTextBox, "");
        }

        private void EmployeeIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrEmpty(EmployeeIDTextBox.Text))
            {
                errorMessage = "Employee name can't be null or empty!";
                WarningProvider.SetError(EmployeeIDTextBox, errorMessage);
                EmployeeIDTextBox.SelectAll();
                e.Cancel = true;
            }
            else
            {
                WarningProvider.SetError(EmployeeNameTextBox, "");
            }          
        }

        private void EmployeeIDTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(EmployeeIDTextBox, "");
        }
    }
}
