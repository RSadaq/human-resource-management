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
            Employee nextEmployee = employer.employees.First();
            jobsAssignedTextBox.Text = nextEmployee.Name.ToUpper() + " to " + jobsComboBox.SelectedItem + " for " + NoOfShiftsNumericUpDown.Value + " Shifts"; 
        }       
    }
}
