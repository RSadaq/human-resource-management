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
    }
}
