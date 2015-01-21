using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationSystem.DAO
{
    public class View
    {
        public string Code { set; get; }
        public string ImageSource { set; get; }
        public string FirstNAme { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public int PersonalContactNo { set; get; }
        public int HomeContactNo { set; get; }
        public string Email { set; get; }
        public string PresentAddress { set; get; }
        public string ParmanentAddress { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime JoiningDate { set; get; }
        public string Gender { set; get; }
        public int Id { set; get; }
        public int DesignationId { set; get; }
        public string DesignationCode { set; get; }
        public string Designation { set; get; }
        public string FullName { set; get; }
        public double BasicAmount { set; get; }
        public double MedicalAmount { set; get; }
        public double ConveyanceAmount { set; get; }
        public double TotalAmount { set; get; }

    }
}
