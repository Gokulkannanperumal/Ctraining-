using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation
{
    public class CURDop
    {
        string connectionString = @"Data Source=DESKTOP-U0B9PRL\SQLEXPRESS;Initial Catalog=ganapathihotel;Integrated Security=True";


        //CURD Operations
        //C=> Create
        //U => Update
        //R =>Read
        //D => Delete

        DataTable OBJNewDT = null;
        public CURDop()
        {
            //primary key
            OBJNewDT = new DataTable("Users");
            //Create
            DataColumn Useridcolumn = new DataColumn("UserId", typeof(int));
            OBJNewDT.Columns.Add(Useridcolumn)
;            OBJNewDT.Columns.Add("Name", typeof(string));
            OBJNewDT.Columns.Add("Email", typeof(string));
            OBJNewDT.PrimaryKey = new DataColumn[] { Useridcolumn };
        }

        public void Create(int userId, string name, string email)
        {
            DataRow row = OBJNewDT.NewRow();
            row["UserId"] = userId;
            row["Name"] = name;
            row["Email"] = email;
            OBJNewDT.Rows.Add(row);
            Console.WriteLine("User added successfully.");
        }


        public void read()
        {
            Console.WriteLine("User Records:");
            foreach (DataRow row in OBJNewDT.Rows)
            {
                Console.WriteLine($"UserId: {row["UserId"]}, Name: {row["Name"]}, Email: {row["Email"]}");
            }
        }

        public void ReadById(int userId)
        {
            DataRow row = OBJNewDT.Rows.Find(userId); // Use primary key to find row
            if (row != null)
            {
                Console.WriteLine($"UserId: {row["UserId"]}, Name: {row["Name"]}, Email: {row["Email"]}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void Update(int userId, string name, string email)
        {
            DataRow row = OBJNewDT.Rows.Find(4);
            if (row != null)
            {
                row["Name"] = name;
                row["Email"] = email;
                Console.WriteLine("User updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void Delete(int userId)
        {
            DataRow row = OBJNewDT.Rows.Find(userId);
            if (row != null)
            {
                row.Delete();
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
