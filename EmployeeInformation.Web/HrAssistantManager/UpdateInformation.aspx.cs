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
    public partial class UpdateInformation : System.Web.UI.Page
    {
        ViewManager aManager = new ViewManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            updateGridView.DataSource = aManager.GetAll();
            updateGridView.DataBind();

        }

       
    }
}