using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformation.DAL;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformationSystem.BLL
{
    public class EmployeeManager
    {
        EmployeeDbGateway aGateway = new EmployeeDbGateway();

        public string Save(Employee aEmployee)
        {
            if (aGateway.UniqueCheker(aEmployee.Email) == null)
            {
                aGateway.Save(aEmployee);
                return "Saved";
            }
            else
            {
                return "Email must be Unique";
            }
        }

        public List<Employee> GetAll()
        {
            return aGateway.GetAll();
        }

        public Employee Find(int id)
        {
            return aGateway.Find(id);
        }
    }
}
