using System;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAO;

namespace EmployeeInformation.Web
{
    public partial class SaveDesignation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            DesignationManager aDesignationManager =new DesignationManager();
            Designation aDesignation = new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;
            string msg = aDesignationManager.Save(aDesignation);
            msgLabel.Text = msg;
        }
    }
}