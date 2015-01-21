using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using EmployeeInformationSystem.DAO;


namespace EmployeeInformation.DAL
{
    public class DesignationDbGateway :DbGateway
    {
       

        public DesignationDbGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }

        public void Save(Designation aDesignation)
        {
            string query = "INSERT INTO tbl_designation VALUES('" + aDesignation.Code + "' , '" + aDesignation.Title +
                           "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public List<Designation> GetAll()
        {
            string query = "SELECT *FROM tbl_designation";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            List<Designation> designations = new List<Designation>();

            while (aSqlDataReader.Read())
            {

                Designation aDesignation = new Designation();
                aDesignation.Id = (int)aSqlDataReader["id"];
                aDesignation.Code = aSqlDataReader["shortForm"].ToString();
                aDesignation.Title = aSqlDataReader["title"].ToString();
                designations.Add(aDesignation);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return designations;
        }
        public Designation Find(string code)
        {

            string query = "SELECT *FROM tbl_designation WHERE shortForm='" + code + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Read();
               Designation aDesignation = new Designation();

                aDesignation.Code = aSqlDataReader["shortForm"].ToString();

                aSqlDataReader.Close();
                aSqlConnection.Close();

                return aDesignation;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
          
        }

    }
}
