using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace HumanResourceManagement
{
    [TestClass]
    public class EmployerTest
    {
        public EmployerTest()
        {
            one = new Employer();
            one.ConnectionString = this.ConnectionString;//Ensures instance of Employer class connects to the dummy database.
        }

        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feroz\OneDrive\Documents\csharpProjects\HumanResourceManagement\HumanResourceManagement\HRMTestDatabase.mdf;Integrated Security = True";
        List<String> ls = new List<String>() { "Tills", "Stocking_shelves", "Internet_shopping", "Customer_Services", "Meat", "Bakery" };
        Employer one;
        public int shifts;
        public String current_job;

        [TestMethod]
        public void GetEmployees_Validated()
        {
            one.EmployeesAvailableAndTrained.Clear();
            UpdateJobDetailsCorrectly();
            String jobSelected = ls[new Random().Next(0, 5)];
            CollectionAssert.AllItemsAreNotNull(one.EmployeesAvailableAndTrained);

            one.Getemployees(jobSelected);
            CollectionAssert.AllItemsAreNotNull(one.EmployeesAvailableAndTrained);
            Assert.AreEqual("John Knight", one.EmployeesAvailableAndTrained[1579]);

        }
        
        public void UpdateJobDetailsCorrectly()
        {
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql2 = "UPDATE Assignment SET Current_Job = '', Shifts = 0 WHERE Name = 'John Knight'";
                using (adapter.UpdateCommand = new SqlCommand(sql2, con))
                {                    
                    adapter.UpdateCommand.ExecuteNonQuery();
                }            
            }
        }

        [TestMethod]
        public void JobDetailsUpdated_Correctly()
        {
           
            string Name = "John Knight";
            int Shifts = 3;
            String jobSelected = ls[new Random().Next(0, 5)];
            one.AssignJob(jobSelected, Shifts, Name);
            Assert.AreNotEqual(shifts, Shifts);//Should not be equal until after SelectCurrent_JobAndShiftsQuery() runs.
            Assert.AreNotEqual(current_job, jobSelected);
            SelectCurrent_JobAndShiftsQuery(Name);
            Assert.AreEqual(jobSelected, current_job);
            Assert.AreEqual(Shifts, shifts);
           
        }


        public void SelectCurrent_JobAndShiftsQuery(string Name)
        {
           
         SqlConnection con;
         using (con = new SqlConnection(ConnectionString))
            {
               con.Open();
               String sql = "SELECT Current_Job, Shifts FROM Assignment WHERE Name = '" + Name +"'";
               using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                {
                                shifts = (int)reader["Shifts"];
                                current_job = reader["Current_Job"].ToString();
                                }
                            }
                        }
                    }
            }
        }

        [TestMethod]
        public void StartShiftUpdatesNoOfShiftsANDJobToNull_Correctly()//Checks that StartShift() from Employer class is being updated correctly & Current_Job is null when Shifts = 0;
        {
            UpdateJobDetailsCorrectly();//Sets Current_Job to Null & Shifts to 0.
            string Name = "John Knight";
            int Shifts = 3;
            String jobSelected = ls[new Random().Next(0, 5)];
            one.AssignJob(jobSelected, Shifts, Name);
            SelectCurrent_JobAndShiftsQuery(Name);//Selects Shifts & Current_Job from dummy database - as defined above in Name, Shifts & jobSelected
            Assert.AreEqual(jobSelected, current_job);
            Assert.AreEqual(Shifts, shifts);

            one.StartShift();//Check values before and afterthis method called.
            SelectCurrent_JobAndShiftsQuery(Name);
            Assert.AreEqual(2, shifts);

            one.StartShift();//Check value of shifts is now 2-1.
            SelectCurrent_JobAndShiftsQuery(Name);
            Assert.AreEqual(1, shifts);
            Assert.AreEqual(jobSelected, current_job);

            one.StartShift();//Check value of shifts is now 1-0 & Current_Job is an Empty string/null.
            SelectCurrent_JobAndShiftsQuery(Name);
            Assert.AreEqual(0, shifts);
            Assert.AreEqual("", current_job);
        }
    }
}
