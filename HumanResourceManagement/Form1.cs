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
        }

        Employer employer = new Employer();
        
        private void assignJobButton_Click(object sender, EventArgs e)
        {
            if (AvlbleEmplsComboBox.Items.Count == 0)//Job cannot be assigned before an available employee is chosen.
            {
                MessageBox.Show("Please select an available employee first!");
            }
            else
            {
                jobsAssignedTextBox.Text = AvlbleEmplsComboBox.SelectedItem.ToString().ToUpper() + " to " + jobsComboBox.SelectedItem + " for " + NoOfShiftsNumericUpDown.Value + " Shifts";
                employer.AssignJob(jobsComboBox.SelectedItem.ToString(), (int)NoOfShiftsNumericUpDown.Value, AvlbleEmplsComboBox.SelectedItem.ToString());
            }
            
        }

        private void AvlblEmplysButton_Click(object sender, EventArgs e)//Names of employee names from employer.employees list added to items in ComboBox so user can choose which available employee should do chosen job.
        {
            foreach (Employee nextEmployee in employer.employees)
            {
                AvlbleEmplsComboBox.Items.Add(nextEmployee.Name);
            }
        }
    }
}
