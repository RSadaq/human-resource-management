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
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feroz\OneDrive\Documents\csharpProjects\HumanResourceManagement\HumanResourceManagement\HRMTestDatabase.mdf;Integrated Security = True";

        [TestMethod]
        public void GetEmployees_Validated()
        {
            Employer one = new Employer();
            one.ConnectionString = this.ConnectionString;
            List<String> ls = new List<String>() {"Tills", "Stocking_shelves", "Internet_shopping", "Customer_Services", "Meat", "Bakery"};

            one.EmployeesAvailableAndTrained.Clear();
            DoQuery();
            String jobSelected = ls[new Random().Next(0, 5)];

            one.Getemployees(jobSelected);
            CollectionAssert.AllItemsAreNotNull(one.EmployeesAvailableAndTrained);
            Assert.AreEqual("John Knight", one.EmployeesAvailableAndTrained[1579]);

        }
        
        public void DoQuery()
        {
            Dictionary<int, string> EmployeesAvailableAndTrainedTest = new Dictionary<int, string>();
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
    }
}
