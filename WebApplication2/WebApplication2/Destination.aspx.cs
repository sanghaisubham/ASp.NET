using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Destination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string code, name, salary;
            code = Request.QueryString["Code"];
            name = Request.QueryString["Name"];
            salary = Request.QueryString["Salary"];

            Label1.Text = code;
            Label2.Text = name;
            Label3.Text = salary;


        }
    }
}