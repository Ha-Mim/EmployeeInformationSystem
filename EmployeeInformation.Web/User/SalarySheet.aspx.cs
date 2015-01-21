using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInformationSystem.BLL;

namespace EmployeeInformation.Web.User
{
    public partial class SalarySheet : System.Web.UI.Page
    {
        SalaryManager aManager = new SalaryManager();
            
     protected void Page_Load(object sender, EventArgs e)
     {
         salaryGridView.DataSource = aManager.GetSalary();
          salaryGridView.DataBind();
         grandtotalTextBox.Text = aManager.GetGrandTotal().ToString();
     }
    }
}