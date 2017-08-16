using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            var employeeDataAccessLayer = new EmployeeDataAccessLayer();

          var result = employeeDataAccessLayer.SaveCompanyDetails(model);
            if (result > 0)
            {
                var display = "Successful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');",
                    true);
            }
            else
            {
                var display = "UnSuccessful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');",
                    true);
            }

        }

        protected void CompanyClearButton_Click(object sender, EventArgs e)
        {
            EmployerNameTextBox.Text = "";
            EmployerContactNumberTextBox.Text = "";
            EmployerLocationTextBox.Text = "";
            EmployerWebsiteTextBox.Text = "";
            EmployeeIdTextBox.Text = "";
        }

        protected void CompanyEditButton_Click(object sender, EventArgs e)
        {

            var model = new CompanyModel
            {
                EmployerName = EmployerNameTextBox.Text,
                ContactNumber =EmployerContactNumberTextBox.Text,
                Place = EmployerLocationTextBox.Text,
                Website = EmployerWebsiteTextBox.Text,
                EmployeeId = Convert.ToInt32(EmployeeIdTextBox.Text)

            };

            var EditCompanyId = Convert.ToInt32(DropDownList3.Text);
            var mysqlconnection =
                new SqlConnection
                {
                    ConnectionString =
                        "Data Source = BAIBHAV;database = PioneerConsultancyDatabase ;Integrated security = SSPI"
                };

            SqlCommand cmd = new SqlCommand("UPDATE [CompanyDetail] SET[EmployerName] = " +
                                            "'" + model.EmployerName + "',[ContactNumber] = " + model.ContactNumber + ",[Place] = '" + model.Place + "',[Website] =' " +model.Website+
                                            "',[EmployeeID] = " + model.EmployeeId + "WHERE CompanyID = " + EditCompanyId, mysqlconnection);
            mysqlconnection.Open();

            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                var display = "Successful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');",
                    true);
            }
            else
            {
                var display = "UnSuccessful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');",
                    true);
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        { 
            var employeeDataAccessLayer = new EmployeeDataAccessLayer();
            var result=  employeeDataAccessLayer.GetCompanyCode(Convert.ToInt32(DropDownList3.Text));
            EmployerNameTextBox.Text = result.EmployerName;
            EmployerContactNumberTextBox.Text = result.ContactNumber;
            EmployerLocationTextBox.Text = result.Place;
            EmployerWebsiteTextBox.Text = result.Website;

        }
    }
}