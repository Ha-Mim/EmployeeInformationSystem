using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace EmployeeInformation.DAL
{
    public class DbGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["connectionStringForEmployeeDB"].ConnectionString;
        public SqlConnection aSqlConnection;
        public SqlCommand aSqlCommand;
    }
}
