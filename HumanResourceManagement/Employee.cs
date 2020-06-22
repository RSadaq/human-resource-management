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
        private int id;
        
        public Employee(int Id, string Name)
        {
            this.name = Name;
            this.id = Id;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Id
        {
            get
            {
                return Id;
            }
        }

        //Removed properties not needed.
    }
}
