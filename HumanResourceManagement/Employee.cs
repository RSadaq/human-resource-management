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
        public string JobAssigned;
        private int numberOfShiftsAssigned;
        private int numberOfShiftsCompleted;

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
                currentJob = JobAssigned; //Value from UI/database
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
                numberOfShiftsAssigned = value; //Value from UI/database
            }
        }
    }
}
