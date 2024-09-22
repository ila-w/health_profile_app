using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthProfileApp
{
    public partial class PatientReport : System.Web.UI.Page
    {
        Patient person = new Patient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string message;

            try
            {
                string fn = Request.Form["fname"];
                string ln = Request.Form["lname"];
                string gn = Request.Form["gender"];
                int h = int.Parse(Request.Form["height"]);
                int w = int.Parse(Request.Form["weight"]);
                int m = int.Parse(Request.Form["month"]);
                int d = int.Parse(Request.Form["day"]);
                int y = int.Parse(Request.Form["year"]);

                person.Name = fn + " " + ln;
                person.Gender = gn;
                person.Age = y;
                person.Height = h;
                person.Weight = w;
                person.Max = 0;
                person.Target = "";
                person.BMI = 0;

                message = "<h2>Patient Report</h2>" + person.getPatientInfo();
                Response.Write(message);
            }
            catch (Exception ex)
            {
                Response.Redirect("ReportError.aspx");
            }
        }
    }
}