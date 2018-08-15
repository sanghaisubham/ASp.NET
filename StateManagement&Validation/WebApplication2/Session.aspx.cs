/*
 * Sessions can be used to store even complex data for the user just like cookies. 
 * Sessions will use cookies to store the data, unless you explicitly tell it not to. 
 *  Sessions can be used easily in ASP.NET with the Session object. 
 *  Session values are tied to an instance of our browser. If we close down the browser, the saved value(s) will usually be "lost".
 *  If the webserver recycles the aspnet_wp.exe process, sessions are lost, 
    since they are saved in memory as well. 
 * This can be avoided by saving session states on a separate StateServer 
   or by saving to a SQL server
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["BackgroundColor"] != null)
            {
                ColorSelector.SelectedValue = Session["BackgroundColor"].ToString();
                BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            }
        }
        protected void ColorSelector_IndexChanged(object sender, EventArgs e)
        {
            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            Session["BackgroundColor"] = ColorSelector.SelectedValue;
        }
    }
}