using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformation.DAL;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformationSystem.BLL
{
   public class ViewManager
    {
        ViewDbGateway  aGateway = new ViewDbGateway();

        public List<View> SearchByCode(string code)
        {
                return aGateway.SearchEmployee(code);
            }
            public List<View> SeachByName(string name) 
            {
                return aGateway.SearchEmployeeByName(name);
            }

       public string Update(View aEmployee)
       {
          aGateway.Update(aEmployee);
           return "Successfully Updated";
       }

       public List<View> GetAll()
       {
           return aGateway.GetAll();
       }

       public void Delete(View aEmployee)
       {
           aGateway.Delete(aEmployee);
       }

       public View GetAnEmployee(int empId)
       {
         return aGateway.GetEmployee(empId);
           
       }
    }
        
    }

