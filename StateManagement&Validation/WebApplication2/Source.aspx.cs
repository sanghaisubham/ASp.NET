/*Client Side State Management:
 
 * ViewState
 * Cookies
 * QueryString
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Source : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string querystring = string.Format("Destination.aspx?Code={0}&Name={1}&Salary={2}",100,Server.UrlEncode("Subham#?$$"),80000);
            Response.Redirect(querystring);

            //Pass information in key value pair .
            //Send info to page =>Destination.aspx
            //Info consists of Code,name and Salary

        }
    }
}