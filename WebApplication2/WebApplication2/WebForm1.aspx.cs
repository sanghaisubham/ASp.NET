using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string message;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack==false)
            //    Response.Write("First Request");
            ///*First Time when page is loaded , it is the 1st request,
            ////which is not a POSTBACK*/
            //else
            //    Response.Write("Not the First Request");

            if (!IsPostBack)
                //message = "Hello World";
                //Label1.Text = "Hello World";
                //ViewState["msg"] = "Hello World";
                HiddenField1.Value = "Hello World";
    
            //View State is a property of control
            //stored in the page and sent to the server in case of POST request
            //ViewState is a StateBag(dictionary)
            /*Labels are view state and are page based to store the state information for a single user*/


        }
        //After every request the state is lost and new object has new values
        //ASP.NEt uses view state to preserve controls
        //View State is required to maintain because HTTP is a stateless protocol
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = message;
            //Label1.Text = Label1.Text;
            // Label1.Text = ViewState["msg"].ToString();
            Label1.Text = HiddenField1.Value;
        }
    }
}