/*
 * Spproach to saving data for the user, is the ViewState
 * ViewState allows ASP.NET to repopulate form fields on each 
    postback to the server, making sure that a form is not automatically 
    cleared when the user hits the submit button.
 * Cookies and sessions can be accessed from all your pages on your website, 
    ViewState values are not carried between pages. 
 * The NameLabel still contains the name, but so does the textbox. 
   The first thing is because of us, while the textbox is maintained by ASP.NET 
   itself. 
 * Try deleting the value and pressing the second button again. 
    We  will see that the textbox is now cleared, but our name label keeps 
    the name, because the value we saved to the ViewState is still there!
 * ViewState is pretty good for storing simple values for use in the form, 
   but if we wish to save more complex data, and keep them from page to page,
   we should look into using cookies or sessions.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["NameOfUser"] != null)
                NameLabel.Text = ViewState["NameOfUser"].ToString();
            else
                NameLabel.Text = "Not set yet...";
        }
        protected void SubmitForm_Click(object sender, EventArgs e)
        {
            ViewState["NameOfUser"] = NameField.Text;
            NameLabel.Text = NameField.Text;
        }
    }
}