using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation
{
    public class CURD_DB_NSP
    {
        //ADO .Net
        string connectionString = @"Data Source=DESKTOP-U0B9PRL\SQLEXPRESS;Initial Catalog=CURDOperation;Integrated Security=True";

        //CREate An Record
        public void AddProduct(string name, decimal price)
        {
            string query = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);

                connection.Open();
                //
                //command.ExecuteReader();
                //command.ExecuteScalar();

                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Data Inserted");
                }
                else { Console.WriteLine("Data Insertion failed"); }
            }
        }
        //read the data
        public void GetProduct(int id)
        {
            string query = "SELECT Id, Name, Price FROM Products WHERE Name like '%Soa%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
                    }
                }
            }
        }

        public void GetAllProducts()
        {
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
                    }
                }
            }
        }

        public void UpdateProduct(int id, string name, decimal price)
        {
            string query = "UPDATE Products SET Name = @Name, Price = @Price WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);

                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Data Updated");
                }
                else { Console.WriteLine("Data Updated failed"); }

            }
        }

        public void DeleteProduct(int id)
        {
            string query = "DELETE FROM Products WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Data Removed");
                }
                else { Console.WriteLine("Data Remove failed"); }

            }
        }


    }
}
