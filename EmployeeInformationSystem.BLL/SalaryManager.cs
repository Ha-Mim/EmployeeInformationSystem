using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformation.DAL;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformationSystem.BLL
{
    public class SalaryManager
    {
        public string SaveSalary(Salary aSalary)
        {
            SalaryDbGateway aGateway = new SalaryDbGateway();
            if (aGateway.UniqueId(aSalary.EmployeeId) == null)
            {
                aGateway.Save(aSalary);
                return "Sucessfully Saved";
            }
            else
            {
                return "Already exists";
            }
        }

        public List<View> GetSalary()
        {
           EmployeeManager aManager = new EmployeeManager();
           SalaryDbGateway aGateway = new SalaryDbGateway();
           List< Salary> Salaryss = aGateway.GetSalary();
           List<View> employeeSalaries = new List<View>();
            foreach (Salary aSalary in Salaryss)
            {
               View aEmployee = new View();

                aEmployee.Code = aManager.Find(aSalary.EmployeeId).Code;
                aEmployee.FullName = aManager.Find(aSalary.EmployeeId).GetFullName();
                aEmployee.Email = aManager.Find(aSalary.EmployeeId).Email;
                aEmployee.BasicAmount = aSalary.BasicAmount;
                aEmployee.MedicalAmount = aSalary.GetMedicalAmount();
                aEmployee.ConveyanceAmount = aSalary.GetMedicalAmount();
                aEmployee.TotalAmount = aSalary.GetTotalSalary();
                employeeSalaries.Add(aEmployee);
            }
            return employeeSalaries;
        }

        public double GetGrandTotal()
        {
            double grandTotal = 0;
            foreach (View aView in GetSalary())
            {
                grandTotal += aView.TotalAmount;
            }
            return grandTotal;
        }
    }
}
