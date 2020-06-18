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
            employer.ConnectToDatabase();
            foreach (Employee nextEmployee in employer.employees)
            {
                AvlbleEmplsComboBox.Items.Add(nextEmployee.Name);
            }
        }

        Employer employer = new Employer();
        
        private void assignJobButton_Click(object sender, EventArgs e)
        {
            if (jobsComboBox.SelectedItem != null && NoOfShiftsNumericUpDown.Value != 0 && AvlbleEmplsComboBox.SelectedItem != null)//Job will only be assigned if employee and job selected. No. of shifts must be above 0.
            {
                jobsAssignedTextBox.Text = AvlbleEmplsComboBox.SelectedItem.ToString().ToUpper() + " to " + jobsComboBox.SelectedItem + " for " + NoOfShiftsNumericUpDown.Value + " Shifts";
                employer.AssignJob(jobsComboBox.SelectedItem.ToString(), (int)NoOfShiftsNumericUpDown.Value, AvlbleEmplsComboBox.SelectedItem.ToString());
            }
            else
                MessageBox.Show("Please complete all fields!");
        }
    }
}
