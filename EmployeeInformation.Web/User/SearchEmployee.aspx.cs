using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAO;


namespace EmployeeInformation.Web.User
{
    public partial class SearchEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ViewManager aManager = new ViewManager();
        protected void searchByCodeButton_Click(object sender, EventArgs e)
        {
            string code = codeTextBox.Text;
            searchGridView.DataSource= aManager.SearchByCode(code);
            searchGridView.DataBind();


        }

        protected void searchByNameButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            searchGridView.DataSource = aManager.SeachByName(name);
            searchGridView.DataBind();

        }

        protected void salarySetupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalarySetUp.aspx");
        }

        protected void SalarySheetButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalarySheet.aspx");
        }

      

        }
    }
