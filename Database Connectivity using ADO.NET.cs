using System;
using Microsoft.Data.SqlClient;

class Practical10
{
    static void Main()
    {
        Console.WriteLine("Connecting to database...");

        string connString = @"Data Source=localhost;Initial Catalog=TestDB;Integrated Security=True;TrustServerCertificate=True;";


        using (SqlConnection conn = new SqlConnection(connString))
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Users (Name) VALUES ('John Doe')";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
        }

        Console.WriteLine("Done. Press Enter to exit.");
        Console.ReadLine();
    }
}