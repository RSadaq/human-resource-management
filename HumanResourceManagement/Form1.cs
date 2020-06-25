using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                  
        }

        Employer employer = new Employer();

        private void jobsComboBox_SelectedIndexChanged(object sender, EventArgs e)//Show available employees for selected Job.
        {
            AvlbleEmplsComboBox.ResetText();
            startShiftButton.Enabled = false;
            employer.EmployeesAvailableAndTrained.Clear();
            AvlbleEmplsComboBox.Items.Clear();

            employer.Getemployees(jobsComboBox.SelectedItem.ToString());

            foreach (KeyValuePair<int, string> emp in employer.EmployeesAvailableAndTrained)
            {
                AvlbleEmplsComboBox.Items.Add(emp.Key + "," + emp.Value);
            }
            AvlbleEmplsComboBox.Enabled = true;
            NoOfShiftsNumericUpDown.Enabled = true;
        }

        private void assignJobButton_Click(object sender, EventArgs e)
        {
            if (jobsComboBox.SelectedItem != null && NoOfShiftsNumericUpDown.Value != 0 && AvlbleEmplsComboBox.SelectedItem != null)//Job will only be assigned if employee and job selected. No. of shifts must be above 0.
            {
                
                jobsAssignedTextBox.Text = AvlbleEmplsComboBox.SelectedItem.ToString().ToUpper() + " to " + jobsComboBox.SelectedItem + " for " + NoOfShiftsNumericUpDown.Value + " Shifts";

                string EmployeeInfo = AvlbleEmplsComboBox.SelectedItem.ToString();
                string EmployeeName = EmployeeInfo.Substring(EmployeeInfo.LastIndexOf(',') + 1);
                employer.AssignJob(jobsComboBox.SelectedItem.ToString(), (int)NoOfShiftsNumericUpDown.Value, EmployeeName);
                AvlbleEmplsComboBox.ResetText();
                startShiftButton.Enabled = true;
                NoOfShiftsNumericUpDown.Value = 0;
                jobsComboBox.ResetText();
            }
            else
            {
                MessageBox.Show("Please complete all fields!");
            }
           
        }

        private void startShiftButton_Click(object sender, EventArgs e)
        {
            employer.StartShift();
            jobsAssignedTextBox.Text += "\r\nSHIFT STARTED! ";
            startShiftButton.Enabled = false;
        }
    }
}

