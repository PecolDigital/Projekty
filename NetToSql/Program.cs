using System;
using System.Data.SqlClient;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=Biblioteka;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Dodanie książki
                string insertQuery = "INSERT INTO Books (Title, Author, Year) VALUES (@Title, @Author, @Year)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", "Władca Pierścieni");
                    cmd.Parameters.AddWithValue("@Author", "J.R.R. Tolkien");
                    cmd.Parameters.AddWithValue("@Year", 1954);
                    cmd.ExecuteNonQuery();
                }

                // Wyświetlenie książek
                string selectQuery = "SELECT * FROM Books";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Książki w bazie:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]}: {reader["Title"]} by {reader["Author"]} ({reader["Year"]})");
                    }
                }
            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey(); //Dowolny klawisz zamyka program :)
        }
    }
}
