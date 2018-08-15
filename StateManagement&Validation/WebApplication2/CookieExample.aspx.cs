/* ~~~~~~~~~~~~~~~~~~~~~~~~~COOkie ~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Cookie are creted by Website and stored on CLient Side
 * Cookies are Text information.
 * 2 Types:
 =>Permanent:Have a Expiry Date
 => Temporary
 * Travel with request and response
 * A website can only access its own cookies created by it.
 * Cookies can store maximum of 4 KB
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebApplication2
{
    public partial class CookieExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        HttpCookie cookie;
        protected void Button1_Click(object sender, EventArgs e)
        {
            cookie = Request.Cookies["user"];//if request has "user" cookie?
            //Checked in server side
            if(cookie==null)
            {
                cookie = new HttpCookie("user");
                cookie.Value = TextBox1.Text;
                if(CheckBox1.Checked==true)
                {
                    cookie.Expires = DateTime.Now.AddDays(2);
                }
                //Temporary cookie is stored in Browser
                //Permanent cookie is stored as a file in Computer
                Response.Cookies.Add(cookie);

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                Label2.Text = "Hello " + cookie.Value;
            }
            else
                Label2.Text = "Hello User";

        }
    }
}