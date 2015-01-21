using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformation.DAL
{
    public class SalaryDbGateway :DbGateway
    {
        
        public SalaryDbGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }

        public void Save(Salary aSalary)
        {
            string query = "INSERT INTO tbl_salary VALUES('" + aSalary.BasicAmount + "' , '" + aSalary.MedicalPercentage + "','"+aSalary.ConveyancePercentage+"','"+aSalary.EmployeeId+"')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public List<Salary> GetSalary()
        {
            string query = "SELECT *FROM tbl_salary";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            List<Salary> employeeSalaries = new List<Salary>();
            while (aSqlDataReader.Read())
            {
                
               
                Salary aSalary = new Salary();
                aSalary.Id = Convert.ToInt32(aSqlDataReader["id"]);
                aSalary.BasicAmount = Convert.ToDouble(aSqlDataReader["basicAmount"]);
                aSalary.MedicalPercentage = Convert.ToDouble(aSqlDataReader["medicalPercentage"]);
                aSalary.ConveyancePercentage = Convert.ToDouble(aSqlDataReader["conveyancePercentage"]);
                aSalary.EmployeeId = Convert.ToInt32(aSqlDataReader["employeeId"]);
              
                employeeSalaries.Add(aSalary);

            }
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return employeeSalaries;

        }

        public Salary UniqueId(int employeeId)
        {
            foreach (Salary aSalary in GetSalary())
            {
                if (aSalary.EmployeeId == employeeId)
                {
                    return aSalary;
                }
            }
            return null;
        }
    }
}
