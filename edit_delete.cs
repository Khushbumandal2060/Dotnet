
/* 
 * using MySql.Data.MySqlClient;
using System;

namespace DatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=dotnet_bca;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("✅ Connected to database.");

                    // ===== UPDATE Operation =====
                    Console.Write("Enter roll number to update: ");
                    int rollToUpdate = int.Parse(Console.ReadLine());

                    Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();

                    string updateQuery = "UPDATE students SET name = @name WHERE roll = @roll";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@name", newName);
                        updateCmd.Parameters.AddWithValue("@roll", rollToUpdate);

                        int rowsUpdated = updateCmd.ExecuteNonQuery();
                        Console.WriteLine(rowsUpdated > 0 ? "✅ Student updated successfully." : "❌ No student found with that roll.");
                    }

                    // ===== DELETE Operation =====
                    Console.Write("\nEnter roll number to delete: ");
                    int rollToDelete = int.Parse(Console.ReadLine());

                    string deleteQuery = "DELETE FROM students WHERE roll = @roll";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@roll", rollToDelete);

                        int rowsDeleted = deleteCmd.ExecuteNonQuery();
                        Console.WriteLine(rowsDeleted > 0 ? "✅ Student deleted successfully." : "❌ No student found with that roll.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("❌ Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ General error: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
 
*/
