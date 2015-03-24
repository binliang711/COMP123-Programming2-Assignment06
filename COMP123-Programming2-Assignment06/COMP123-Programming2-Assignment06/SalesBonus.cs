using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            EmployeeIDLabel.Text = Properties.Resources.EmployeeIDLabelEnglish;

            HoursWorkedLabel.Text = Properties.Resources.HoursWorkedLabelEnglish;

            TotalSalesLabel.Text = Properties.Resources.TotalSalesLabelEnglish;

            SalesBonusLabel.Text = Properties.Resources.SalesBonusLabelEnglish;

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

            if (hoursWorked > 160)
            {
                errorMessage = "Maxmum working hours is no more than 160 hours!";
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
    }
}
