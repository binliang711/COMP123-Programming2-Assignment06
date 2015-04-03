/*
 * studentName:Bin Liang | studentNumber:300788322
 * Date last Modified:April 2nd,2015
 * Program description:COMP123_Assignment06,Array Practice-Airline Reservations System.
 * Revision	History:
 * 1.Create label,textBox,and button.
 * 2.FAdd pictureBox.
 * 3.Add language groupbox and radiobuttons.
 * 4.Repair PictureBox.
 * 5.Add WarningProvider for HoursWorkedTextBox.
 * 6.Calculate Button has been debugged successfully!
 * 7.NextButton has been debugged successfully!
 * 8.Solved the rightalign problems for both languages.
 * 9.Display a print preview successfully!
 * 10.Improve total sales valid data check.
 * 11.Improve other textboxes valid data check.
 * 12.Improve internal documentation.
 * 13.Improve TapIndes.
 */
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

        // EVENT HANDLER - ENGLISH RADIO BUTTON HANDLER - Checked Changed event
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.TitleBarStringEnglish;

            LanguageGroupBox.Text = Properties.Resources.GroupBoxEnglish;

            EnglishRadioButton.Text = Properties.Resources.EnglishRadioButtonEnglish;

            FrenchRadioButton.Text = Properties.Resources.FrenchRadioButtonEnglish;

            EmployeeNameLabel.Text = Properties.Resources.EmployeeNameLabelEnglish;
            EmployeeNameLabel.TextAlign = ContentAlignment.MiddleRight;//When switch from french to English,MiddleRight align again!

            EmployeeIDLabel.Text = Properties.Resources.EmployeeIDLabelEnglish;
            EmployeeIDLabel.TextAlign = ContentAlignment.MiddleRight;//When switch from french to English,MiddleRight align again!

            HoursWorkedLabel.Text = Properties.Resources.HoursWorkedLabelEnglish;
            HoursWorkedLabel.TextAlign = ContentAlignment.MiddleRight;//When switch from french to English,MiddleRight align again!
            
            TotalSalesLabel.Text = Properties.Resources.TotalSalesLabelEnglish;
            TotalSalesLabel.TextAlign = ContentAlignment.MiddleRight;//When switch from french to English,MiddleRight align again!

            SalesBonusLabel.Text = Properties.Resources.SalesBonusLabelEnglish;
            SalesBonusLabel.TextAlign = ContentAlignment.MiddleRight;//When switch from french to English,MiddleRight align again!

            CalculateButton.Text = Properties.Resources.CalculateButtonStringEnglish;

            NextButton.Text = Properties.Resources.NextButtonStringEnglish;

            PrintButton.Text = Properties.Resources.PrintButtonStringEnglish;
        }

        // EVENT HANDLER - FRENCH RADIO BUTTON HANDLER - Checked Changed event
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

        //EVENT HANDLER - Check valid data of HoursWorkedTextBox
        private void HoursWorkedTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "";
            int hoursWorked = Convert.ToInt32(HoursWorkedTextBox.Text);

            if (hoursWorked > 160 || hoursWorked <= 0)
            {
                errorMessage = "Maximum working hours must be less than or equal to 160 hours, or greater than zero!";
                WarningProvider.SetError(HoursWorkedTextBox, errorMessage);// Set the WarningProvider error with the text to display. 
                HoursWorkedTextBox.SelectAll();
                e.Cancel = true;// Cancel the event and select the text to be corrected by the user.
            }
            else
            {
                errorMessage = "";
            }
        }

        // If all conditions have been met, clear the WarningProvider of errors.
        private void HoursWorkedTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(HoursWorkedTextBox, "");
        }

        //EVENT HANDLER - Check valid data of TotalSalesTextBox
        private void TotalSalesTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "";                    
            string totalSales ="";

            if (string.IsNullOrEmpty(TotalSalesTextBox.Text))//Check whether the data is null or empty
            {
                errorMessage = "Employee name can't be null or empty!";
                WarningProvider.SetError(TotalSalesTextBox, errorMessage);
                TotalSalesTextBox.SelectAll();
                e.Cancel = true;
            }
            else if (Convert.ToDouble(TotalSalesTextBox.Text) <= 0)//Check whether the data is <=0
            {
                errorMessage = "Total sales must greater than zero!";
                WarningProvider.SetError(TotalSalesTextBox, errorMessage);
                TotalSalesTextBox.SelectAll();
                e.Cancel = true;
            }
            else//check and display a value using standard currency format
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

        // If all conditions have been met, clear the WarningProvider of errors.
        private void TotalSalesTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(TotalSalesTextBox, "");
        }

        //EVENT HANDLER -  Calculate the sales bonus earned by the employee
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

        //EVENT HANDLER -  Clear the textbox value.
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            HoursWorkedTextBox.Text = "";
            SalesBonusTextBox.Text = "";
        }

        //EVENT HANDLER -  Display a print preview for the form
        private void PrintButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        //EVENT HANDLER - Check valid data of EmployeeNameTextBox
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

        // If all conditions have been met, clear the WarningProvider of errors.
        private void EmployeeNameTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(EmployeeNameTextBox, "");
        }

        //EVENT HANDLER - Check valid data of EmployeeIDTextBox
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

        // If all conditions have been met, clear the WarningProvider of errors.
        private void EmployeeIDTextBox_Validated(object sender, EventArgs e)
        {
            WarningProvider.SetError(EmployeeIDTextBox, "");
        }
    }
}
