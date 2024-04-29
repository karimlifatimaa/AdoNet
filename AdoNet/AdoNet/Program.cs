using AdoNet.Models;
using AdoNet.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe()
            {
                Name = "Adil",
                Surname = "Kerimli",
                Salary = 2000

            };
            EmployeService employeService = new EmployeService();

            employeService.Create(employe);
            foreach (var item in employeService.GetAll())
            {
                Console.WriteLine(item);
            }
            employeService.Delete(0);

            //string con = "server=DESKTOP-VHCECVJ\\SQLEXPRESS;database=BB207_ADO;Trusted_connection=true;integrated security=true";
            //using (SqlConnection connection = new SqlConnection(con))
            //{
            //    connection.Open();
            //    string command = "insert into Users values('Fatime')";
            //    SqlCommand cmd = new SqlCommand(command, connection);
            //    int result = cmd.ExecuteNonQuery();
            //    if (result > 0)
            //    {
            //        Console.WriteLine("Data elave olundu");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Problem bas verdi");
            //    }
            //    string query = "select * from Users";
            //    SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);
            //    foreach(DataRow item in dataTable.Rows)
            //    {
            //        Console.WriteLine(item["Id"]+" "+ item["Name"]);
            //    }

            //}

        }
    }
}
