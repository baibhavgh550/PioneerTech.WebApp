using System;

namespace PioneerTech.Models.Model
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailId { get; set; }
        public long MobileNumber { get; set; }
        public long AlternateMobile { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String HomeCountry { get; set; }
        public String CurrentCountry { get; set; }
        public long  ZipCode { get; set; }

    }
}