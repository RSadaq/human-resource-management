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
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feroz\OneDrive\Documents\csharpProjects\HumanResourceManagement\HumanResourceManagement\Employee.mdf;Integrated Security = True";

        public Dictionary<int, string> EmployeesAvailableAndTrained = new Dictionary<int, string>();

        public void Getemployees(string Job)//This method finds employees are available & who could potentially do the job.
        {
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand command;
                SqlDataReader reader;
                String sql = "";
                sql = "SELECT DISTINCT Assignment.Id, Name FROM Assignment, Jobs WHERE Jobs.Id = Assignment.Id AND (Current_Job IS NULL OR Current_Job = ' ') AND " + Job + " = 1";
                using (command = new SqlCommand(sql, con))
                {
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            {
                                EmployeesAvailableAndTrained.Add((int)reader["Id"], reader["Name"].ToString());
                            }
                        }
                    }
                }

            }

        }
        public void AssignJob(string Job, int Shifts, string Name) //User input provides these arguments - This method confirms user actions & updates database with new jobs & shifts assigned.
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

        //public void StartJob()//Employee starts shifts on given job - minuses 1 from current no. of shifts in database
        //{
        //    SqlConnection con;

        //    using (con = new SqlConnection(ConnectionString))
        //    {

        //        con.Open();
        //        SqlCommand command;
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        String sql = "";
        //        sql = "UPDATE Assignment SET Shifts = Shifts - 1 WHERE Shifts > 0 ";//Once shift starts, minus one from shifts remaining for that job.
        //        command = new SqlCommand(sql, con);
        //        adapter.UpdateCommand = new SqlCommand(sql, con);
        //        adapter.UpdateCommand.ExecuteNonQuery();

        //        command.Dispose();
        //        con.Close();
        //    }
        //}

        public void StartJob()//Employee starts shifts on given job - minuses 1 from current no. of shifts in database
        {
            SqlConnection con;

            using (con = new SqlConnection(ConnectionString))
            {

                con.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";
                sql = "UPDATE Assignment SET Shifts = Shifts - 1 WHERE Shifts > 0 ";//Once shift starts, minus one from shifts remaining for that job.
                command = new SqlCommand(sql, con);
                adapter.UpdateCommand = new SqlCommand(sql, con);
                adapter.UpdateCommand.ExecuteNonQuery();

                SqlCommand command_1;
                SqlDataAdapter adapter_1 = new SqlDataAdapter();
                String sql_1 = "";
                sql_1 = "UPDATE Assignment SET Current_Job = NULL WHERE Shifts = 0 ";//Once shift starts, minus one from shifts remaining for that job.
                command_1 = new SqlCommand(sql_1, con);
                adapter.UpdateCommand = new SqlCommand(sql_1, con);
                adapter.UpdateCommand.ExecuteNonQuery();

                command.Dispose();
                command_1.Dispose();
                con.Close();
            }
        }


    }
}



