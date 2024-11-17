using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation
{
    public class CURD_DB_SP
    {
        string connectionString = @"Data Source=DESKTOP-U0B9PRL\SQLEXPRESS;Initial Catalog=CURDOperation;Integrated Security=True";


        public CURD_DB_SP()
        {

        }

        ~CURD_DB_SP()
        {
            Console.WriteLine("Destructor called");
            // Perform cleanup if needed
        }
        public void AddProduct(string name, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spAddProduct", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);

                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Data Inserted");
                }
                else { Console.WriteLine("Data Insertion failed"); }

            }
        }
        public void GetProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spGetProduct", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spGetAllProducts", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spUpdateProduct", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spDeleteProduct", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Data Deleted");
                }
                else { Console.WriteLine("Data Deleted failed"); }

            }
        }
    }
}
