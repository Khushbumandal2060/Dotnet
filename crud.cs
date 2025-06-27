using MySql.Data.MySqlClient;
using System;

namespace CRUDExample
{
    class Program
    {
        static string connectionString = "Server=localhost;Database=dotnet_bca;Uid=root;Pwd=;";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n==== CRUD Operations ====");
                Console.WriteLine("1. Create (Insert Student)");
                Console.WriteLine("2. Read (View Students)");
                Console.WriteLine("3. Update (Edit Student)");
                Console.WriteLine("4. Delete (Remove Student)");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertStudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void InsertStudent()
        {
            Console.Write("Enter Roll: ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO students (roll, name, email, phone, course) VALUES (@roll, @name, @email, @phone, @course)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@roll", roll);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@course", course);

                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine(rows > 0 ? "✅ Student Inserted." : "❌ Insert Failed.");
                }
            }
        }

        static void ViewStudents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM students";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
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

        static void UpdateStudent()
        {
            Console.Write("Enter Roll to Update: ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE students SET name = @name WHERE roll = @roll";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@roll", roll);

                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine(rows > 0 ? "✅ Student Updated." : "❌ No Record Found.");
                }
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Roll to Delete: ");
            int roll = int.Parse(Console.ReadLine());

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM students WHERE roll = @roll";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@roll", roll);

                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine(rows > 0 ? "✅ Student Deleted." : "❌ No Record Found.");
                }
            }
        }
    }
}
