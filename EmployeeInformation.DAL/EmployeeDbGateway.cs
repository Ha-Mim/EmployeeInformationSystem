using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformation.DAL
{
    public class EmployeeDbGateway : DbGateway
    {
        public EmployeeDbGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }

        public void Save(Employee aEmployee)
        {

            string query = "INSERT INTO tbl_Employee VALUES ('" + aEmployee.Code + "','" + aEmployee.FirstNAme + "','" +
                           aEmployee.MiddleName + "','" +
                           aEmployee.LastName + "','" + aEmployee.Email + "','" + aEmployee.PersonalContactNo + "','" +
                           aEmployee.HomeContactNo + "','" + aEmployee.DateOfBirth + "','" + aEmployee.PresentAddress +
                           "','" + aEmployee.ParmanentAddress + "','" + aEmployee.JoiningDate + "','" + aEmployee.Gender +
                           "','" + aEmployee.ImageSource + "','" + aEmployee.DesignationId + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Employee UniqueCheker(string email)
        {
            string query = "SELECT *FROM tbl_employee WHERE email='" + email + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Read();
                Employee aEmployee = new Employee();

                aEmployee.Email = aSqlDataReader["email"].ToString();

                aSqlDataReader.Close();
                aSqlConnection.Close();

                return aEmployee;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }

    
        public List<Employee> GetAll()
        {

            string query = "SELECT *FROM tbl_employee";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (aSqlDataReader.Read())
            {
                Employee aEmployee = new Employee();
                aEmployee.Id = Convert.ToInt32(aSqlDataReader["id"]);
                aEmployee.FirstNAme = aSqlDataReader["firstName"].ToString();
                aEmployee.MiddleName = aSqlDataReader["middleName"].ToString();
                aEmployee.LastName = aSqlDataReader["lastname"].ToString();
                aEmployee.Email = aSqlDataReader["email"].ToString();
                aEmployee.Code = aSqlDataReader["code"].ToString();
                aEmployee.FullName = aEmployee.GetFullName();
                employees.Add(aEmployee);
               
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return employees;

        }

        public Employee Find(int id)
        {
            foreach (Employee anEmployee in GetAll())
            {
                if (anEmployee.Id == id)
                {
                    return anEmployee;
                }
            }
            return null;
        }
        }
    }

