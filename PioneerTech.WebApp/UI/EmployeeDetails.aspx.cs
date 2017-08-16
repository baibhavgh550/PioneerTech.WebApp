using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibraryProject;
using PioneerTech.Consultancy.DAL;
using PioneerTech.Models.Model;

namespace PioneerTech.WebApp
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeModel = new EmployeeModel
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    EmailId = EmailIdTextBox.Text,
                    MobileNumber = Convert.ToInt64(MobileNumberTextBox.Text),
                    AlternateMobile = Convert.ToInt64(AlternateMobileNumberTextBox.Text),
                    Address1 = AddressTextBox.Text,
                    Address2 = AlternateAddressTextBox.Text,
                    HomeCountry = HomeCountryTextBox.Text,
                    CurrentCountry = CurrentCountryTextBox.Text,
                    ZipCode = Convert.ToInt32(ZipCodeTextBox0.Text)
                };

                var employeeDataAccessLayer = new EmployeeDataAccessLayer();
                var result = employeeDataAccessLayer.SaveEmployeeDetails(employeeModel);
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
            catch (Exception ex)
            {

                this.Session["exceptionMessage"] = ex.Message;
                Response.Redirect("ErrorDisplay.aspx");

            }


        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            EmailIdTextBox.Text = "";
            MobileNumberTextBox.Text = "";
            AlternateMobileNumberTextBox.Text = "";
            AddressTextBox.Text = "";
            AlternateAddressTextBox.Text = "";
            HomeCountryTextBox.Text = "";
            CurrentCountryTextBox.Text = "";
            ZipCodeTextBox0.Text = "";
        }
    }
}