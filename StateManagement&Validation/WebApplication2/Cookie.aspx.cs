/*
 * Cookies are small pieces of text, stored on the client's computer to be 
    used only by the website setting the cookies.

 * This allows webapplications to save information for the user, 
   and then re-use it on each page if needed.
 */
/*
 * First, the Page_Load method, which is called on each page request.
   Here we check for a cookie to tell us which background color should be used. 
   If we find it, we set the value of our dropdown list to reflect this, 
   as well as the background color of the page, simply by accessing the style 
   attribute of the body tag.
   
 * Then we have the ColorSelector_IndexChanged method, 
   which is called each time the user selects a new color.
   Here we set the background color of the page, and then we create a cookie, 
   to hold the value for us. We allow it to expire after one hour, 
   and then we set it by calling the SetCookie method on the Response object.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["BackgroundColor"] != null)
            {
                ColorSelector.SelectedValue = Request.Cookies["BackgroundColor"].Value;
                BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            }
        }
        protected void ColorSelector_IndexChanged(object sender, EventArgs e)
        {
            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            HttpCookie cookie = new HttpCookie("BackgroundColor");
            cookie.Value = ColorSelector.SelectedValue;
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.SetCookie(cookie);//Upates the cookie in the cookie collection
           // Response.Cookies.Add(cookie);//Adds the cookie in cookie collection
        }
    }
}