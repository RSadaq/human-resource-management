using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement
{
    class Employee
    {
        private string name;
        private string [] jobsEmployeeCanDo;//array holds jobs an employee could potentially do.
        private string currentJob;
        private int numberOfShiftsAssigned;
        private int numberOfShiftsCompleted;
       

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
                return numberOfShiftsAssigned - numberOfShiftsCompleted;
            }

            set
            {
                numberOfShiftsAssigned = value; //Value from database
            } 
        }
    }
}
