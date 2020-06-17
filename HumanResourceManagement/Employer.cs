using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement
{
    public class Employer
    {
        public List<Employee> employees = new List<Employee>();
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feroz\OneDrive\Documents\csharpProjects\HumanResourceManagement\HumanResourceManagement\Employee.mdf;Integrated Security = True";
        
        public void ConnectToDatabase()//DON'T NEED THIS METHOD IF ASSIGNING JOBS DIRECTLY IN DATABASE!!!!
        {
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))//'using' so all objects closed correctly.
            {
                con.Open();
                SqlCommand command;//Need this to query
                SqlDataReader reader;//For viewing result       
                String sql = "";
                sql = "SELECT Name FROM Assignment WHERE Current_Job IS NULL OR Current_Job = ' '";
                using (command = new SqlCommand(sql, con))
                {
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee(reader["Name"].ToString()));
                        }
                    }
                }                
                   
            }
            
        } 
        
        public void AssignJob(string Job, int Shifts, string Name) //User input provides these arguments.
        {
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();//For adapting data (deleting, inserting or updating).
                String sql = "";
                sql = "UPDATE Assignment SET Current_Job = '" + Job + "'" + ", Shifts = '" + Shifts + "'" + " WHERE Current_Job IS NULL OR Current_Job = ' ' AND Name ='" + Name + "'";
                command = new SqlCommand(sql, con);
                adapter.UpdateCommand = new SqlCommand(sql, con);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                con.Close();
            }
        }
        public void StartJob() { }//Employee starts shifts on given job.
        //public bool JobFinished() { }//New jobs can only be assigned if system 'knows' when an employee is available.

    }

}

