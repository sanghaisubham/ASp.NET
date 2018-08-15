using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load( object sender, EventArgs e)
        {
            //implicitly typed local variables
            //var n;
            //var n = null;
            // var cannot be specified as return type
            //input parameters cannot be of type var
            //data members cannot be of type var;

            //nullable types
            int? salary = 2300;
            //Nullable<int> salary2 = null;
            // show(salary);

            int number = 1234;
            // int result=number.Reverse();
            int result = ExtensionMethods.Reverse(number);
            Response.Write(result);
        }
        void show(int? data)
        {
            if (data.HasValue)
                Response.Write(data.Value);
            else
                Response.Write("Null");
        }
     
    }
    public static class ExtensionMethods
    {
        public static int Reverse(int x )
        {
            string reverse = "";
            string str = x.ToString();
            char[] ary = str.ToCharArray();
            for (var i = ary.Length - 1; i >= 0; i--)
            {
                reverse += ary[i];
            }
            return Convert.ToInt32(reverse);
        }
    }
}