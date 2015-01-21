using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeInformation.Web.HrAssistantManager
{
    public partial class HRAM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SaveEmployee.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateInformation.aspx");
        }
    }
}