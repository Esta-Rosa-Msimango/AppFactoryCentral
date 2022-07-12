using System;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class AFCentralAccess //private access test here
    {
        public AFCentralAccess(string myString) 
        {
            MyConnectionString = myString;
        }

        public string MyConnectionString { get; init; }

        public void insert(string name, string surname, string position, string email, string phone, string ProgrammeName)
        {
            using(SqlConnection cn = new (MyConnectionString))
            {
                using(SqlCommand cmd = new ())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "spInsertToTables";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    //member table
                    cmd.Parameters.AddWithValue("@FirstName", name);
                    cmd.Parameters.AddWithValue("@LastName", surname);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@ProgrammeName", ProgrammeName);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }   
    }
}