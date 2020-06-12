using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement
{
    class Employer
    {
        private Employee[] employees;//Employer needs to track which employees are currently on a job, for how many shifts etc.
        public void AssignJob(string Job) { } //Assigns jobs and number of shifts
        public void StartJob() { }//Employee starts shifts on given job.
        public bool JobFinished() { }//New jobs can only be assigned if system 'knows' when an employee is available.
    }
}
