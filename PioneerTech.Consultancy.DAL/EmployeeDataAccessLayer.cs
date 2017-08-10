
using System.Data.SqlClient;
using MyClassLibraryProject.Model;
using PioneerTech.Models.Model;

namespace PioneerTech.Consultancy.DAL
{
    public class EmployeeDataAccessLayer
    {

        public int SaveEmployeeDetails(EmployeeModel employeeModel)
        {
            var sqlConnectionString = new SqlConnection();
            sqlConnectionString.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";

            using (var command = sqlConnectionString.CreateCommand())
            {
                command.CommandText = "INSERT INTO EmployeeDetail" +
                                      "(FirstName, LastName, Email, ContactNumber, AlternateContactNumber, [Address], AlternateAddress, CurrentCountry, HomeCountry, Zipcode) " +
                                      "VALUES " +
                                      "(@firstName,@lastName,@email,@mobileNumber,@alternateMobile,@address1,@address2,@currentCountry,@homeCountry,@zipCode)";

                command.Parameters.AddWithValue("@firstName", employeeModel.FirstName);
                command.Parameters.AddWithValue("@lastName", employeeModel.LastName);
                command.Parameters.AddWithValue("@email", employeeModel.EmailId);
                command.Parameters.AddWithValue("@mobileNumber", employeeModel.MobileNumber);
                command.Parameters.AddWithValue("@alternateMobile", employeeModel.AlternateMobile);
                command.Parameters.AddWithValue("@address1", employeeModel.Address1);
                command.Parameters.AddWithValue("@address2", employeeModel.Address2);
                command.Parameters.AddWithValue("@currentCountry", employeeModel.CurrentCountry);
                command.Parameters.AddWithValue("@homeCountry", employeeModel.HomeCountry);
                command.Parameters.AddWithValue("@zipCode", employeeModel.ZipCode);
                sqlConnectionString.Open();

                var result = command.ExecuteNonQuery();
                sqlConnectionString.Close();

                return result;

            }
        }

        public int SaveProjectDetails(ProjectModel projectModel)
        {
            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";

            using (var com = conn.CreateCommand())
            {
                com.CommandText =
                    "INSERT INTO ProjectDetail VALUES(@projectName, @clientName,@place,@role,@employeeId)";

                com.Parameters.AddWithValue("@projectName", projectModel.ProjectName);
                com.Parameters.AddWithValue("@clientName", projectModel.ClientName);
                com.Parameters.AddWithValue("@place", projectModel.Place);
                com.Parameters.AddWithValue("@role", projectModel.Role);
                com.Parameters.AddWithValue("@employeeId", projectModel.EmployeeId);

                conn.Open();
                var result = com.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }

        public int SaveCompanyDetails(CompanyModel companyModel)
        {
            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";

            using (var com = conn.CreateCommand())
            {
                com.CommandText =
                    "INSERT INTO CompanyDetail VALUES(@employerName, @contactNumber,@place,@website,@employeeId)";

                com.Parameters.AddWithValue("@projectName", companyModel.EmployerName);
                com.Parameters.AddWithValue("@contactNumber", companyModel.ContactNumber);
                com.Parameters.AddWithValue("@place", companyModel.Place);
                com.Parameters.AddWithValue("@website", companyModel.Website);
                com.Parameters.AddWithValue("@employeeId", companyModel.EmployeeId);

                conn.Open();
                var result = com.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }

        public int SaveTechnicalDetails(TechnicalModel technicalModel)
        {
            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";

            using (var com = conn.CreateCommand())
            {
                com.CommandText =
                    "INSERT INTO TechnicalDetail VALUES(@UI, @ProgrammingLanguage,@DatabaseName,@employeeId)";

                com.Parameters.AddWithValue("@UI", technicalModel.UI);
                com.Parameters.AddWithValue("@ProgrammingLanguage", technicalModel.ProgrammingLanguage);
                com.Parameters.AddWithValue("@DatabaseName", technicalModel.Database);
                com.Parameters.AddWithValue("@employeeId", technicalModel.EmployeeId);

                conn.Open();
                var result = com.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }

        public int SaveEducationDetail(EducationModel educationModel)
        {
            var conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=BAIBHAV;" +
                "Initial Catalog=PioneerConsultancyDatabase;" +
                "Integrated security = True;";

            using (var com = conn.CreateCommand())
            {
                com.CommandText =
                    "INSERT INTO EducationDetail VALUES(@CourseType, @YearOfPass,@CourseSpecialization,@employeeId)";

                com.Parameters.AddWithValue("@CourseType", educationModel.CourseType);
                com.Parameters.AddWithValue("@YearOfPass", educationModel.YearOfPass);
                com.Parameters.AddWithValue("@CourseSpecialization", educationModel.CourseSpecialization);
                com.Parameters.AddWithValue("@employeeId", educationModel.EmployeeId);
                conn.Open();
                var result = com.ExecuteNonQuery();
                conn.Close();
                return result;
            }
        }

    }
}

