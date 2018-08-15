using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class SessionExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session.SessionID;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["number"] = 1000;
            Person person = new Person()
            {
                age = 20,
                name = "Subham Sanghai"
            };
            Session["friend"] = person;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Person p = (Person)Session["friend"];
            if (p == null)
                TextBox1.Text = "Session Does not Exist";
            else
            TextBox1.Text = p.name + " " + p.age;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Session.RemoveAll();
            //Session.RemoveAt(1);
            Session.Remove("friend");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session.Abandon();//Cancels or closes the current session
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}/*
//State Service is an external source and it is different than the application.
//SO it is stored seperately than our application .SO we need to serialize
//Before WorkProcess was used which was part of the application
//So we did not had to serialize to store in that case
*/