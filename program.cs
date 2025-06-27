using MySql.Data.MySqlClient;
using System;

namespace DatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // MySQL connection string — update server, user, password as needed
            string connectionString = "Server=localhost;Database=dotnet_bca;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Connected to database.");

                    // Insert operation
                    string insertQuery = "INSERT INTO students (roll, name, email, phone, course) " +
                                         "VALUES (@roll, @name, @email, @phone, @course)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@roll", 1);
                        insertCmd.Parameters.AddWithValue("@name", "Khushbu Mandal");
                        insertCmd.Parameters.AddWithValue("@email", "khushbu@example.com");
                        insertCmd.Parameters.AddWithValue("@phone", "9844993923");
                        insertCmd.Parameters.AddWithValue("@course", "Computer Science");

                        int rows = insertCmd.ExecuteNonQuery();
                        Console.WriteLine($"{rows} row(s) inserted.");
                    }

                    // Select operation
                    string selectQuery = "SELECT roll, name, email, phone, course FROM students";

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            Console.WriteLine("\nRoll\tName\t\tEmail\t\t\tPhone\t\tCourse");
                            Console.WriteLine("---------------------------------------------------------------------");
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["roll"]}\t{reader["name"]}\t{reader["email"]}\t{reader["phone"]}\t{reader["course"]}");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
