using AdoNet.DataBase;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Services
{
    internal class EmployeService
    {
        AppDbContext DbContext;
        public EmployeService()
        {
            this.DbContext = new AppDbContext();
        }
        public void Create(Employe employe)
        {
            string createCommand = $"insert into Employees values('{employe.Name}','{employe.Surname}','{employe.Salary}')";
            int result = DbContext.NonQuery(createCommand);
        }
        public List<Employe> GetAll()
        {
            string query = "Select * from Employees";
            DataTable table = DbContext.Query(query);
            List<Employe> list = new List<Employe>();
            foreach(DataRow item in table.Rows)
            {
                Employe employe = new Employe()
                {
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Salary = double.Parse(item["Salary"].ToString())


                };
                list.Add(employe);
            }
            return list;
        }
        public void Delete(int id)
        {
            string command = $"delete from Empoyees where Id={id}";
            DbContext.NonQuery(command); 
        }
    }
}
