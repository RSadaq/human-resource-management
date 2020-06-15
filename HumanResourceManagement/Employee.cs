using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HumanResourceManagement
{
    public class Employee
    {
        private string name;
        private string [] jobsEmployeeCanDo;
        private string currentJob;
        private int numberOfShiftsAssigned;
        private int numberOfShiftsCompleted;


        public Employee(string Name, string Current_Job, int Shifts)
        {
            this.name = Name;
            this.currentJob = Current_Job;
            this.numberOfShiftsAssigned = Shifts;
        }

        public Employee(string Name)
        {
            this.name = Name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }

            set
            {
                currentJob = value; //Value from database
            }
        }

        public int NumberOfShifts
        {
            get
            {
                return numberOfShiftsAssigned;
            }

            set
            {
                numberOfShiftsAssigned = value; //Value from database
            }
        }
    }
}
