using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAO;
using View = EmployeeInformationSystem.DAO.View;

namespace EmployeeInformation.Web.HrAssistantManager
{
    public partial class EditInformation : System.Web.UI.Page
    {
        ViewManager aEmployeeManager = new ViewManager();
        DesignationManager aManager = new DesignationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                designationDropDownList.DataTextField = "Title";
                designationDropDownList.DataValueField = "Id";
                designationDropDownList.DataSource = aManager.GetAll();
                designationDropDownList.DataBind();

                int empId = Convert.ToInt32(Request.QueryString[0]);

                View anEmployee = aEmployeeManager.GetAnEmployee(empId);
                codeTextBox.Text = anEmployee.Code;
                designationDropDownList.SelectedValue = anEmployee.Designation;
                firstnameTextBox.Text = anEmployee.FirstNAme;
                middleNameTextBox.Text = anEmployee.MiddleName;
                lastNameTextBox.Text = anEmployee.LastName;
                dateOfBirthTextBox.Text = anEmployee.DateOfBirth.ToLongDateString();
                genderTextBox.Text = anEmployee.Gender;
                presenttAddressTextBox.Text = anEmployee.PresentAddress;
                parmanentAddressTextBox.Text = anEmployee.ParmanentAddress;
                personalContactNoTextBox.Text = Convert.ToString(anEmployee.PersonalContactNo);
                homeContactNoTextBox.Text = anEmployee.HomeContactNo.ToString();
                emailTextBox.Text = anEmployee.Email;
                joiningDateTextBox.Text = anEmployee.JoiningDate.ToLongDateString();
                ImageShow.ImageUrl = anEmployee.ImageSource;
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            View aEmployee = new View();
            aEmployee.ImageSource = ImageShow.ImageUrl;
            aEmployee.FirstNAme = firstnameTextBox.Text;
            aEmployee.MiddleName = middleNameTextBox.Text;
            aEmployee.LastName = lastNameTextBox.Text;
            aEmployee.Code = codeTextBox.Text;
            aEmployee.DateOfBirth = Convert.ToDateTime(dateOfBirthTextBox.Text);
            aEmployee.JoiningDate = Convert.ToDateTime(joiningDateTextBox.Text);
            aEmployee.PersonalContactNo = Convert.ToInt32(personalContactNoTextBox.Text);
            aEmployee.HomeContactNo = Convert.ToInt32(homeContactNoTextBox.Text);
            aEmployee.PresentAddress = presenttAddressTextBox.Text;
            aEmployee.ParmanentAddress = parmanentAddressTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.DesignationId = Convert.ToInt32(designationDropDownList.SelectedValue);
           
                aEmployee.Gender = genderTextBox.Text;
          
            
           
            string msg = aEmployeeManager.Update(aEmployee);
            msgLabel.Text = msg;
        }
    }
}