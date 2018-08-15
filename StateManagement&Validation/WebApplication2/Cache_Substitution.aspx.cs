using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Cache_Substitution : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected static string GetFreshDateTime(HttpContext context)
        {
            return DateTime.Now.ToString();
        }
    }
}