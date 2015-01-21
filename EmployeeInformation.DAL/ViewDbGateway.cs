using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformation.DAL
{
    public class ViewDbGateway:DbGateway
    {
        public ViewDbGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }
        public List<View> SearchEmployee(string code)
        {
            List< View> aList = new List<View>();
            foreach (View aView in GetAll())
            {
                if (aView.Code == code)
                {
                    aList.Add(aView);
                }
            }
            return aList;
        }

        public List<View> SearchEmployeeByName(string name)
        {
            string query =
                "SELECT *FROM tbl_employee EMP LEFT JOIN tbl_designation DES On EMP.designationId=DES.id WHERE EMP.firstName Like'%" + name + "%' OR  EMP.middleName Like'%" + name + "%' OR EMP.lastName Like'%" + name + "%'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            List<View> aList = new List<View>();
            while (aSqlDataReader.Read())
            {
                View aEmployee = new View();
               aEmployee.ImageSource = aSqlDataReader["image"].ToString();
                aEmployee.Id = Convert.ToInt32(aSqlDataReader["id"]);
                aEmployee.FirstNAme = aSqlDataReader["firstName"].ToString();
                aEmployee.MiddleName = aSqlDataReader["middleName"].ToString();
                aEmployee.LastName = aSqlDataReader["lastName"].ToString();
                aEmployee.PersonalContactNo = Convert.ToInt32(aSqlDataReader["personalContactNo"]);
                aEmployee.HomeContactNo = Convert.ToInt32(aSqlDataReader["homeContactNo"]);
                aEmployee.Email = aSqlDataReader["email"].ToString();
                aEmployee.PresentAddress = aSqlDataReader["presentAddress"].ToString();
                aEmployee.ParmanentAddress = aSqlDataReader["permanentAddress"].ToString();
                aEmployee.DateOfBirth = Convert.ToDateTime(aSqlDataReader["dateOfBirth"]);
                aEmployee.JoiningDate = Convert.ToDateTime(aSqlDataReader["joiningDate"]);
                aEmployee.DesignationId = Convert.ToInt32(aSqlDataReader["designationId"].ToString());
                aEmployee.Gender = aSqlDataReader["gender"].ToString();
                aEmployee.Code = aSqlDataReader["code"].ToString();
                aEmployee.DesignationCode = aSqlDataReader["shortForm"].ToString();
                aEmployee.Designation = aSqlDataReader["title"].ToString();
                aList.Add(aEmployee);
            }
              aSqlDataReader.Close();
              aSqlConnection.Close();

            return aList;
            }

        public void Update(View aEmployee)
        {

            string updateQuery = "UPDATE tbl_employee SET code='" + aEmployee.Code + "',firstName='" +
                                 aEmployee.FirstNAme + "',middleName='" +
                                 aEmployee.MiddleName + "',lastname='" +
                                 aEmployee.LastName + "',Email='" + aEmployee.Email + "',personalContactNo='" +
                                 aEmployee.PersonalContactNo + "',homeContactNo='" +
                                 aEmployee.HomeContactNo + "',dateOfBirth='" + aEmployee.DateOfBirth +
                                 "',presentAddress='" + aEmployee.PresentAddress +
                                 "',permanentAddress='" + aEmployee.ParmanentAddress + "" +
                                 "',joiningDate='" +
                                 aEmployee.JoiningDate +
                                 "',gender='" + aEmployee.Gender +
                                 "',image='" + aEmployee.ImageSource + 
                                 "',designationId='" +
                                 aEmployee.DesignationId + 
                                 "' WHERE id= '" + aEmployee.Id+"';";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(updateQuery, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public List<View> GetAll()
        {

            string query = "SELECT *FROM tbl_employee EMP LEFT JOIN tbl_designation DES On EMP.designationId=DES.id";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            List<View> aList = new List<View>();
            while (aSqlDataReader.Read())
            {
                View aEmployee = new View();
                aEmployee.ImageSource = aSqlDataReader["image"].ToString();
                aEmployee.Id = Convert.ToInt32(aSqlDataReader["id"]);
                aEmployee.FirstNAme = aSqlDataReader["firstName"].ToString();
                aEmployee.MiddleName = aSqlDataReader["middleName"].ToString();
                aEmployee.LastName = aSqlDataReader["lastName"].ToString();
                aEmployee.PersonalContactNo = Convert.ToInt32(aSqlDataReader["personalContactNo"]);
                aEmployee.HomeContactNo = Convert.ToInt32(aSqlDataReader["homeContactNo"]);
                aEmployee.Email = aSqlDataReader["email"].ToString();
                aEmployee.PresentAddress = aSqlDataReader["presentAddress"].ToString();
                aEmployee.ParmanentAddress = aSqlDataReader["permanentAddress"].ToString();
                aEmployee.DateOfBirth = Convert.ToDateTime(aSqlDataReader["dateOfBirth"]);
                aEmployee.JoiningDate = Convert.ToDateTime(aSqlDataReader["joiningDate"]);
                aEmployee.DesignationId = Convert.ToInt32(aSqlDataReader["designationId"].ToString());
                aEmployee.Gender = aSqlDataReader["gender"].ToString();
                aEmployee.Code = aSqlDataReader["code"].ToString();
                aEmployee.DesignationCode = aSqlDataReader["shortForm"].ToString();
                aEmployee.Designation = aSqlDataReader["title"].ToString();
                
               aList.Add(aEmployee);
                
            }
               aSqlDataReader.Close();
                aSqlConnection.Close();
                return aList;
            
        }

        public void Delete(View aView)
        {
            string deleteQuery = "DELETE FROM tbl_employee WHERE id=" + aView.Id;
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(deleteQuery, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public View GetEmployee(int empId)
        {
            foreach (View aView in GetAll())
            {
                if (aView.Id == empId)
                {
                    return aView;
                }
            }
            return null;
        }

       
    }
    }

