using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationSystem.DAO
{
    public class Salary
    {
        public int Id { set; get; }
        public double BasicAmount { set; get; }
        public double MedicalPercentage { set; get; }
        public double ConveyancePercentage { set; get; }
        public int EmployeeId { set; get; }

        public double GetMedicalAmount()
        {
            return (MedicalPercentage*BasicAmount)/100;
        }
        public double GetConveyanceAmount()
        {
            return (ConveyancePercentage * BasicAmount) / 100;
        }

        public double GetTotalSalary()
        {
            return BasicAmount + GetConveyanceAmount() + GetMedicalAmount();
        }
    }
}
