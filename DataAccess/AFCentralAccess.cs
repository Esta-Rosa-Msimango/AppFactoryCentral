using System;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class AFCentralAccess
    {
        public AFCentralAccess(string myString) 
        {
            MyConnectionString = myString;
        }

        public string MyConnectionString { get; init; }

        public void insert(string name, string surname, string position, string email, string phone, string ProgrammeName, string ProgrammeDuration)
        {
            using(SqlConnection cn = new (MyConnectionString))
            {
                using(SqlCommand cmd = new ())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "spInsert_Member";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", name);
                    cmd.Parameters.AddWithValue("@LastName", surname);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@Name", ProgrammeName);
                    cmd.Parameters.AddWithValue("@Duration", ProgrammeDuration);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }   
    }
}