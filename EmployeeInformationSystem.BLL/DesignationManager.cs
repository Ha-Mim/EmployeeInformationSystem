using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformation.DAL;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformationSystem.BLL
{
   public class DesignationManager
   {
       DesignationDbGateway aGateway = new DesignationDbGateway();
        public string Save(Designation aDesignation)
        {
            
            if (aGateway.Find(aDesignation.Code) == null)
            {
                aGateway.Save(aDesignation);
                return "Saved";
            }
            else
            {
                return "Already exists";
            }
        }

       public List<Designation> GetAll()
       {
           return aGateway.GetAll();
       }
    }
}
