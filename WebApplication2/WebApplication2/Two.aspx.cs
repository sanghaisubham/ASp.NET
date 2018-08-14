using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Two : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                if (PreviousPage.IsCrossPagePostBack)
                {
                    Response.Write("Cross Page PostBack");
                    One one = (One)PreviousPage;
                    Response.Write("<br/>" + one.Data);
                }
                    

            }
            else
                Response.Write("Page Requested Directly");
        }
    }
}