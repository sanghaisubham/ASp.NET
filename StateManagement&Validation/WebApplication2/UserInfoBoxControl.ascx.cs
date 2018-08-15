using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class UserInfoBoxControl : System.Web.UI.UserControl
    {
        private string userName;
        private int userAge;
        private string userCountry;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int UserAge
        {
            get { return userAge; }
            set { userAge = value; }
        }

        public string UserCountry
        {
            get { return userCountry; }
            set { userCountry = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // These values can come from anywhere, but right now, we just hardcode them
            //MyUserInfoBoxControl.UserName = "Jane Doe";
            //MyUserInfoBoxControl.UserAge = 33;
            //MyUserInfoBoxControl.UserCountry = "Germany";

        }
    }
}
/*A UserControl can't be displayed directly in the browser 
 * - it has to be included on a page.*/