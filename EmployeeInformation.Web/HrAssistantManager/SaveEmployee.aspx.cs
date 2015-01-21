using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Web.DynamicData;
using System.Web.UI.WebControls;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAO;


namespace EmployeeInformation.Web.HrAssistantManager
{
    public partial class SaveEmployee : System.Web.UI.Page
    {
        DesignationManager aManager = new DesignationManager();
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                designationDropDownList.DataTextField = "Title";
                designationDropDownList.DataValueField = "Id";
                designationDropDownList.DataSource = aManager.GetAll();
                designationDropDownList.DataBind();
               
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee();
            aEmployee.ImageSource = ImageShow.ImageUrl;
            aEmployee.FirstNAme = firstnameTextBox.Text;
            aEmployee.MiddleName = middleNameTextBox.Text;
            aEmployee.LastName = lastNameTextBox.Text;
            aEmployee.Code = codeTextBox.Text;
            aEmployee.DateOfBirth = Convert.ToDateTime(dateOfBirthTextBox.Text);
            aEmployee.JoiningDate = joiningDateCalendar.SelectedDate;
            aEmployee.PersonalContactNo = Convert.ToInt32(personalContactNoTextBox.Text);
            aEmployee.HomeContactNo = Convert.ToInt32(homeContactNoTextBox.Text);
            aEmployee.PresentAddress = presenttAddressTextBox.Text;
            aEmployee.ParmanentAddress = parmanentAddressTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            if (Male.Checked)
            {
                aEmployee.Gender = Male.Text;
            }
            else
            {
                aEmployee.Gender = Female.Text;
            }
            aEmployee.DesignationId = Convert.ToInt32(designationDropDownList.SelectedValue);
           EmployeeManager aEmployeeManager =new EmployeeManager();
            string msg=aEmployeeManager.Save(aEmployee);
            msgLabel.Text = msg;
        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.GetFileName(imageFileUpload.PostedFile.FileName);
            imageFileUpload.SaveAs(Server.MapPath("~/Image/" + filePath));
            ImageShow.ImageUrl = "~/Image/" + filePath;
          
        }
    }
}