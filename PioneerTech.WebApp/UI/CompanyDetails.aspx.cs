using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibraryProject.Model;
using PioneerTech.Consultancy.DAL;

namespace PioneerTech.WebApp.UI
{
    public partial class CompanyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CompanySaveButton_Click(object sender, EventArgs e)
        {
            var model = new CompanyModel
            {
                EmployerName = EmployerNameTextBox.Text,
                ContactNumber = EmployerContactNumberTextBox.Text,
                Place= EmployerLocationTextBox.Text,
                Website = EmployerWebsiteTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdTextBox.Text)

            };

            var EmployeeDAL = new EmployeeDataAccessLayer();

            int NoOfRowsAffected = EmployeeDAL.SaveCompanyDetails(model);
        }

        protected void CompanyClearButton_Click(object sender, EventArgs e)
        {
            EmployerNameTextBox.Text = "";
            EmployerContactNumberTextBox.Text = "";
            EmployerLocationTextBox.Text = "";
            EmployerWebsiteTextBox.Text = "";
            EmployeeIdTextBox.Text = "";
        }
    }
}