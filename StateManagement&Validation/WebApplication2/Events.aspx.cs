using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Your Name is " + TextBox1.Text;
            Label3.Text = "Hello, to an employee from " + DropDownList1.SelectedValue;
            //Here note the diff, this only changes on clicking on submit button

            //Not  on changing the select

        }
        protected void DropDown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = "Hello, to an employee from " + DropDownList1.SelectedValue;
            /*This changes on changing the select in the Drop Down because
            We are using the onselectedindexchanged event*/
        }
    }
}