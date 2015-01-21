using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformation.Web.User
{
    public partial class SalarySetUp : System.Web.UI.Page
    {
        EmployeeManager  aManager = new EmployeeManager();
        SalaryManager aSalaryManager = new SalaryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                employeeCodeDropDownList.DataSource = aManager.GetAll();
                employeeCodeDropDownList.DataTextField = "Code";
                employeeCodeDropDownList.DataValueField = "Id";
                employeeCodeDropDownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.EmployeeId = Convert.ToInt32(employeeCodeDropDownList.SelectedValue);
            aSalary.BasicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.MedicalPercentage = Convert.ToDouble(medicalPercentageTextBox.Text);
            aSalary.ConveyancePercentage = Convert.ToDouble(conveyancePercentageTextBox.Text);
            string msg=aSalaryManager.SaveSalary(aSalary);
            msgLabel.Text = msg;
        }

        protected void employeeCodeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
               int id = Convert.ToInt32(employeeCodeDropDownList.SelectedValue);
            Employee anEmployee = aManager.Find(id);
            nameTextBox.Text = anEmployee.FullName;
            emailTextBox.Text = anEmployee.Email;
        }
    }
}